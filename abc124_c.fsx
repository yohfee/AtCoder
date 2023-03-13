let S = stdin.ReadLine()

let rec loop i w b =
    if i = S.Length then
        min w b
    else
        match S.[i], i % 2 with
        | '0', 0
        | '1', 1 -> w, (b + 1)
        | _ -> (w + 1), b
        ||> loop (i + 1)

loop 0 0 0 |> printfn "%d"
