let N = stdin.ReadLine() |> int

stdin.ReadLine().Split " "
|> Array.map int
|> Array.indexed
|> Array.sortBy snd
|> Array.map (fst >> (+) 1 >> string)
|> String.concat " "
|> printfn "%s"
