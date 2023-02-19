let N = stdin.ReadLine() |> int

stdin.ReadLine().Split " "
|> Array.map int
|> Array.sortByDescending id
|> Array.mapi (fun i n -> if i % 2 = 0 then n else -n)
|> Array.sum
|> printfn "%d"
