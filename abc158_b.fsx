let [| N; A; B |] = stdin.ReadLine().Split " " |> Array.map int64
let l = A + B
(N / l) * A + min A (N % l) |> printfn "%d"
