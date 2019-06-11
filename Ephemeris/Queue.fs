module Queue

/// List implementation of a queue. -> This will perform horribly but I can fix performance
/// behind the exposed API.
/// Eventually this will actually abstract a redis queue.
type Queue<'t> = {
    mutable Items: list<'t>
}
with
    /// Returns a list containing a single item if there are items in the queue or returns
    /// an empty list.
    member this.GetItem () =
        match this.Items with
        | [] -> []
        | head::tail ->
            this.Items <- tail
            [head]

    member this.HasItem () =
        match this.Items with
        | [] -> false
        | _ -> true

    /// Returns a list of items from the queue upto count. If there are less items in the queue than requested
    /// the function returns a list of |Queue| length.
    member this.GetItems (count: int) =
        match count > 0 with
        | true -> ()
        | false -> invalidArg "Count" "Count must be a positive number"

        let rec getItems (acc: 't list) remaining =
            match remaining > 0 with
            | true ->
                match this.Items with
                | [] -> acc
                | head::tail ->
                    this.Items <- tail
                    getItems (head::acc) (remaining - 1)
            | false -> acc
        getItems [] count

    member this.Push (item: 't) =
        // let newItems = item::this.Items
        this.Items <- item::(this.Items)