let H = stdin.ReadLine() |> int64

let p n =
    [ 1L .. n ] |> List.fold (fun t _ -> t * 2L) 1L

let rec loop n =
    if p n > H then
        p (n - 1L)
    else
        loop (n + 1L)

loop 0L * 2L - 1L |> printfn "%d"
