let [| N; A; B |] = stdin.ReadLine().Split " " |> Array.map int
let S = stdin.ReadLine()

(0, 0, 0)
|> Seq.unfold (fun (t, b, i) ->
    if i >= N then
        None
    else
        match S.[i] with
        | 'a' when t < A + B -> Some("Yes", (t + 1, b, i + 1))
        | 'b' when t < A + B && b < B -> Some("Yes", (t + 1, b + 1, i + 1))
        | _ -> Some("No", (t, b, i + 1)))
|> Seq.iter (printfn "%s")
