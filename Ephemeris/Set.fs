module CheckoutSet

open System

type Checkout =
    | Booked
    | Free
    | Empty

type CheckoutSet<'t> = {
    SetSize: int
    mutable Items: 't option array
    mutable Ledger: Checkout array
}
with
    static member ConstructCheckoutSet (checkoutSetSize: int) =
        {
            SetSize = checkoutSetSize
            Items = [|for _ in 1..checkoutSetSize -> None |]
            Ledger = [|for _ in 1..checkoutSetSize -> Empty |]
        }






