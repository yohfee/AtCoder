let [| N; M |] = stdin.ReadLine().Split() |> Array.map int

seq {
    for _ in 1..M do
        yield! stdin.ReadLine().Split() |> Array.map int
}
|> Seq.append { 1..N }
|> Seq.countBy id
|> Seq.sortBy fst
|> Seq.iter (snd >> ((+) -1) >> (printfn "%d"))
