// https://stackoverflow.com/questions/5008910/understanding-f-type-constructors

type Foo = 
    val mutable x: int
    val mutable y: int

    new (x: int, y: int)  = 
        { x = x; y = y }
        then 
            printfn "%A" 1

let foo = Foo(100, 200)
printfn "%A %A" foo.x foo.y
