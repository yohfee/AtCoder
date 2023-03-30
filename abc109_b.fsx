let N = stdin.ReadLine() |> int

let rec loop i p s =
    if i = N then
        "Yes"
    else
        let w = stdin.ReadLine()

        if i = 0
           || Seq.last p = Seq.head w
              && not (Set.exists ((=) w) s) then
            loop (i + 1) w (Set.add w s)
        else
            "No"

loop 0 "" Set.empty |> printfn "%s"
