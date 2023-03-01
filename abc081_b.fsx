let N = stdin.ReadLine() |> int
let A = stdin.ReadLine().Split " " |> Array.map int

let rec loop l =
    if l |> Array.exists (fun i -> i % 2 = 1) then
        0
    else
        1 + (l |> Array.map (fun i -> i / 2) |> loop)

A |> loop |> printfn "%d"
