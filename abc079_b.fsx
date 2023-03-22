(match stdin.ReadLine() |> int with
 | 0 -> 2L
 | 1 -> 1L
 | n ->
     (2L, 1L)
     |> Seq.unfold (fun (a, b) -> Some(a + b, (b, a + b)))
     |> Seq.take (n - 1)
     |> Seq.last)
|> printfn "%d"
