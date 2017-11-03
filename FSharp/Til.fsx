// https://stackoverflow.com/questions/5008910/understanding-f-type-constructors

type Foo = 
    val mutable x: int
    val mutable y: int

    new (x: int, y: int) as this = 
        { x = x; y = y }
        then 
            this.x <- 0
            this.y <- 0

let foo = Foo(100, 200)
printfn "%A %A" foo.x foo.y
