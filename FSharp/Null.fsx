

open Microsoft.FSharp.Linq
open System

Nullable(0) ?+ 1 ?+? Nullable()
|> printfn "%A"  // null

type NullableBuilder() =
    let hasValue (a:Nullable<'a>) = a.HasValue 
    member __.Return(x) = Nullable(x)
    member __.Bind(x, rest) = 
        match hasValue x with 
        | false -> System.Nullable() 
        | true -> rest(x.Value)

let nullable = NullableBuilder()
nullable { 
    let! a = Nullable<int>(0)
    let! b = Nullable<int>(1)
    let! c = Nullable<int>()
    return a + b + c
}

|> printfn "%A"

let bind (m, f) = 
    let hasValue (a:Nullable<'a>) = a.HasValue 
    match hasValue m with 
    | false -> System.Nullable() 
    | true -> f(m.Value)

bind(Nullable(3), fun r1 ->
    bind(Nullable(4), fun r2 ->
        bind(Nullable(5), fun r3 ->
            Nullable(r1 + r2 + r3)
        )
    )
)
|> printfn "%A"


