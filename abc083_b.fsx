let [| N; A; B |] = stdin.ReadLine().Split() |> Array.map int

seq {
    for i in 1..N do
        let n =
            i.ToString().ToCharArray()
            |> Array.map (fun c -> int c - 48)
            |> Array.sum

        if A <= n && n <= B then yield i
}
|> Seq.sum
|> printfn "%d"
