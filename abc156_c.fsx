let N = stdin.ReadLine() |> int
let X = stdin.ReadLine().Split " " |> Array.map int

let min = Array.min X
let max = Array.max X

let rec loop p v =
    if p > max then
        v
    else
        let v' = X |> Array.fold (fun a i -> a + pown (i - p) 2) 0
        loop (p + 1) (if v < v' then v else v')

loop min Core.int.MaxValue |> printfn "%d"
