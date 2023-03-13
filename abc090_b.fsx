let [| A; B |] = stdin.ReadLine().Split " " |> Array.map int

let rec loop i =
    if i > B then
        0
    else
        let s = i.ToString().ToCharArray()
        (if s = Array.rev s then 1 else 0) + loop (i + 1)

loop A |> printfn "%d"
