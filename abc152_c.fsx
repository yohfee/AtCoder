let N = stdin.ReadLine() |> int
let P = stdin.ReadLine().Split " " |> Array.map int

let rec loop x i =
    if i = N then
        0
    else
        let p = P.[i]
        (if p > x then 0 else 1) + loop (min p x) (i + 1)

loop N 0 |> printfn "%d"
