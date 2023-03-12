let [| N; M |] = stdin.ReadLine().Split " " |> Array.map int

let rec loop i f =
    if i = N then
        f
    else
        stdin.ReadLine().Split " "
        |> Array.map int
        |> Array.tail
        |> Set
        |> Set.intersect f
        |> loop (i + 1)

[ 1..M ]
|> Set
|> loop 0
|> Set.count
|> printfn "%d"
