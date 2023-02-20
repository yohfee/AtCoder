let N = stdin.ReadLine() |> int

let rec loop n =
    let x = pown 2 n

    if x > N then
        pown 2 (n - 1)
    else
        loop (n + 1)

loop 0 |> printfn "%d"
