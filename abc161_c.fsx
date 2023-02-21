let [| N; K |] = stdin.ReadLine().Split " " |> Array.map int64

let x = N % K
min x (K - x) |> printfn "%d"
