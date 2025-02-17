let x = ref 10
let y = ref 20

let swap x y = 
    let temp = !x
    x := !y
    y := temp

swap x y
printf "%d %d" !x !y //This will print 20 10

//In this solution, we use references to the mutable variables which allows the changes to be reflected outside of the function.

// Alternative approach using tuples

let swapTuple (x,y) = 
    (y,x)

let (a,b) = (10,20)
let (a',b') = swapTuple (a,b)
printf "%d %d" a' b' //prints 20 10