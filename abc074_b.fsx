let N = stdin.ReadLine() |> int
let K = stdin.ReadLine() |> int
let X = stdin.ReadLine().Split " " |> Array.map int

X
|> Array.fold (fun i x -> i + (min x (abs (x - K))) * 2) 0
|> printfn "%d"
