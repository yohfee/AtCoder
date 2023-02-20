let [| K; N |] = stdin.ReadLine().Split " " |> Array.map int
let A = stdin.ReadLine().Split " " |> Array.map int

A |> Array.append <| [| K + A.[0] |]
|> Array.windowed 2
|> Array.map (fun a -> a.[1] - a.[0])
|> Array.sortByDescending id
|> Array.tail
|> Array.sum
|> printfn "%d"
