let N = stdin.ReadLine() |> int
let X = stdin.ReadLine().Split " " |> Array.map int

let pow n = n * n

let x = X |> Array.sort
let min = Array.min x
let max = Array.max x

min
|> Seq.unfold (fun n ->
    if n > max then
        None
    else
        Some(x |> Array.fold (fun a b -> a + pow (b - n)) 0, n + 1))
|> Seq.min
|> printfn "%d"
