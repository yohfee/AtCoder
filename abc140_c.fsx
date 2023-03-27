let N = stdin.ReadLine() |> int
let B = stdin.ReadLine().Split() |> Array.map int

B
|> Seq.mapi (fun i b -> if i = 0 then b else min B.[i] B.[i - 1])
|> Seq.sum
|> (+) (B |> Array.last)
|> printfn "%d"
