let N = stdin.ReadLine() |> int

let rec loop n =
    if pown 2 (n + 1) > N then
        pown 2 n
    else
        loop (n + 1)

loop 0 |> printfn "%d"
