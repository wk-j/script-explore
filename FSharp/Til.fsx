
type Foo = 
    val mutable x : int

    new (i: int) as this = 
        { x = i }
        then this.x <- 0

let foo = Foo(100)
foo.x |> printfn "%A"