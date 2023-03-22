seq {
    yield 2L
    yield 1L
    yield! Seq.unfold (fun (a, b) -> Some(a + b, (b, a + b))) (2L, 1L)
}
|> Seq.skip (stdin.ReadLine() |> int)
|> Seq.head
|> printfn "%d"
