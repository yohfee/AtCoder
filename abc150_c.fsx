let N = stdin.ReadLine() |> int

let P =
    stdin.ReadLine().Split " "
    |> Array.map int
    |> Array.toList

let Q =
    stdin.ReadLine().Split " "
    |> Array.map int
    |> Array.toList

let rec dist e =
    function
    | [] -> [ [ e ] ]
    | x :: xs ->
        (e :: x :: xs)
        :: [ for ys in dist e xs -> x :: ys ]

let rec permute =
    function
    | [] -> [ [] ]
    | x :: xs -> List.collect (dist x) (permute xs)

let a = [ 1..N ] |> permute |> List.sort
let p = a |> List.findIndex ((=) P)
let q = a |> List.findIndex ((=) Q)
p - q |> abs |> printfn "%d"
