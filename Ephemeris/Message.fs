module Message
open System

type Message<'t> = {
    Id: Guid
    Data: 't
    Acknowledge: Guid -> unit
}

type MessageAsync<'t> = {
    Id: Guid
    Data: 't
    Acknowledge: Guid -> Async<unit>
}