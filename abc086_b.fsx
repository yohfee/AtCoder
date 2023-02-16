let s = stdin.ReadLine().Replace(" ", "") |> int

let rec loop n =
    let n' = n * n
    n' <= 100100 && (n' = s || loop (n + 1))

(if loop 0 then "Yes" else "No") |> printfn "%s"
