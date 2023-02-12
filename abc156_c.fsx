let N = stdin.ReadLine() |> int
let X = stdin.ReadLine().Split " " |> Array.map int

let min = Array.min X
let max = Array.max X

let sum =
    let xx = X |> Array.fold (fun a b -> a + pown b 2) 0
    let x = X |> Array.sum
    fun p -> xx + N * pown p 2 - 2 * p * x

let rec loop p v =
    if p > max then
        v
    else
        let v' = sum p
        loop (p + 1) (if v < v' then v else v')

loop min Core.int.MaxValue |> printfn "%d"
