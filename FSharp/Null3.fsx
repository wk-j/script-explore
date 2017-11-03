

open System
open Microsoft.FSharp.Linq

let (>>=) x f = 
    printfn "bind %A" x
    let hasValue (a:Nullable<'a>) = a.HasValue 
    match hasValue x with 
    | false -> System.Nullable() 
    | true -> f(x.Value)

Nullable(1) >>= (?+) (Nullable()) >>= (?+) (Nullable(3))
|> printfn "result %A"
