let s = stdin.ReadLine() |> int

let f n = if n % 2 = 0 then n / 2 else 3 * n + 1
let f' = List.head >> f

let rec loop i l =
    let n' = f' l
    let i' = i + 1

    if List.contains n' l then
        i'
    else
        loop i' (n' :: l)

[ s ] |> loop 1 |> printfn "%d"
