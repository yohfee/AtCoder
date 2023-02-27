let N = stdin.ReadLine() |> int
let [| D; X |] = stdin.ReadLine().Split " " |> Array.map int

seq {
    for _ in 1..N do
        yield (D - 1) / (stdin.ReadLine() |> int) + 1
}
|> Seq.sum
|> (+) X
|> printfn "%d"
