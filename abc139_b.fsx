let [| A; B |] = stdin.ReadLine().Split " " |> Array.map int

let rec loop n =
    if n * (A - 1) + 1 >= B then
        n
    else
        n + 1 |> loop

0 |> loop |> printfn "%d"
