let N = stdin.ReadLine() |> int

stdin.ReadLine().Split " "
|> Array.map float
|> Array.sort
|> Array.reduce (fun a b -> (a + b) / 2.)
|> printfn "%f"
