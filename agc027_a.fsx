let [| N; X |] = stdin.ReadLine().Split " " |> Array.map int64

stdin.ReadLine().Split " "
|> Array.map int64
|> Array.sort
|> Array.scan (+) 0L
|> Array.indexed
|> Array.findBack (snd >> (>=) X)
|> (fun (i, a) -> i - (if int64 i = N && a < X then 1 else 0))
|> printfn "%d"
