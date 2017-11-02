open System

let inline (?+) (x : Nullable<_>) y = 
    if x.HasValue then Nullable(x.Value + y) else Nullable()

let inline (+?) x (y: Nullable<_>) = 
    if y.HasValue then Nullable(x + y.Value) else Nullable()

let inline (?+?) (x : Nullable<_>) (y: Nullable<_>) = 
    if x.HasValue && y.HasValue then Nullable(x.Value + y.Value) else Nullable()