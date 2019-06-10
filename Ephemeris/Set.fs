open System

type Checkout =
    | Booked
    | Free

type CheckoutSet<'t> = {
    SetSize: int
    mutable Items: 't array
    mutable Ledger: Checkout array
} 
with
    static member ConstructCheckoutSet (checkoutSetSize: int) =
        CheckoutSet {
            SetSize = checkoutSetSize
            Items = [||]
            Ledger = [||]
        }






