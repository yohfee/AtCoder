let s =
    stdin.ReadLine().Split " "
    |> String.concat ""
    |> int

let rec loop n =
    n * n <= 100100 && (n * n = s || loop (n + 1))

(if loop 0 then "Yes" else "No") |> printfn "%s"
