let [| N; M |] = stdin.ReadLine().Split " " |> Array.map int

let rec loop l r i =
    if i = M then
        r - l + 1 |> max 0
    else
        let [| L; R |] = stdin.ReadLine().Split " " |> Array.map int
        loop (max l L) (min r R) (i + 1)

loop 1 N 0 |> printfn "%d"
