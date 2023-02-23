let S = stdin.ReadLine()

(0, "")
|> Seq.unfold (fun (i, s) ->
    if i = String.length S then
        None
    else
        let c = S.[i].ToString()

        let s' =
            match c with
            | "A"
            | "C"
            | "G"
            | "T" -> s + c
            | _ -> ""

        Some(s', (i + 1, s')))
|> Seq.map String.length
|> Seq.max
|> printfn "%d"
