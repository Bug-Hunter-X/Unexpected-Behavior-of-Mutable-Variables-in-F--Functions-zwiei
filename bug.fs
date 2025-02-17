let mutable x = 10
let mutable y = 20

let swap x y = 
    let temp = x
    x <- y
    y <- temp

swap x y
printf "%d %d" x y //This will print 20 10

//However, if you try to swap values within a function using mutable variables and return the modified values, the changes will not be reflected outside the function's scope

let swap2 x y = 
    let temp = x
    x <- y
    y <- temp
    (x,y)

let a = 10
let b = 20
let (a',b') = swap2 a b
printf "%d %d" a b // This will print 10 20 because the values have not been changed outside the function.