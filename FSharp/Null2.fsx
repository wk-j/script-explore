open System

type Nullable2Builder() =
    let hasValue (a:Nullable<'a>) = a.HasValue 
    member t.Return(x) = Nullable(x)
    member t.Bind(x, rest) = 
        match hasValue x with 
        | false -> System.Nullable() 
        | true -> rest(x.Value)

let nullable = Nullable2Builder()

nullable.Bind(Nullable(3), fun r1 ->
    nullable.Bind(Nullable(4), fun r2 ->
        nullable.Bind(Nullable(5), fun r3 ->
            nullable.Return(r1 + r2 + r3)
        )
    )
)

|> printfn "%A"