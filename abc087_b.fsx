let A = stdin.ReadLine() |> int
let B = stdin.ReadLine() |> int
let C = stdin.ReadLine() |> int
let X = stdin.ReadLine() |> int

seq {
    for a in 0..A do
        for b in 0..B do
            for c in 0..C do
                if a * 500 + b * 100 + c * 50 = X then
                    yield 1
}
|> Seq.sum
|> printfn "%d"
