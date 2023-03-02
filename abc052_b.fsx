let N = stdin.ReadLine() |> int

stdin.ReadLine().ToCharArray()
|> Array.scan (fun x s -> x + if s = 'I' then 1 else -1) 0
|> Array.max
|> printfn "%d"
