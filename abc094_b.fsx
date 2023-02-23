let [| N; M; X |] = stdin.ReadLine().Split " " |> Array.map int

stdin.ReadLine().Split " "
|> Array.map int
|> Array.fold (fun (l, r) a -> if a < X then (l + 1, r) else (l, r + 1)) (0, 0)
||> min
|> printfn "%d"
