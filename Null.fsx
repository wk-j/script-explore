

open Microsoft.FSharp.Linq
open System

let a = Nullable(0)
a ?+ 1 ?+? Nullable()
|> printfn "%A"  // null

type NullableBuilder() =
    let hasValue (a:Nullable<'a>) = a.HasValue 
    member __.Return(x) = Nullable(x)
    member __.Bind(x, rest) = 
        printfn "-- %A" x
        match hasValue x with 
        | false -> System.Nullable() //.NET null object
        | true -> rest(x.Value)

let nullable = NullableBuilder()
nullable { 
    let! a = Nullable<int>(10)
    let! b = Nullable<int>(1)
    let! c = Nullable<int>(2)
    return a + b + c
    //return a
}
|> printfn "%A"