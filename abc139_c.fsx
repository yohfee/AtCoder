let N = stdin.ReadLine() |> int
let H = stdin.ReadLine().Split() |> Array.map int

let rec loop i n c =
    if i = N then
        n
    else
        (if H.[i - 1] >= H.[i] then
             (c + 1, c + 1)
         else
             (c, 0))
        ||> fun a -> loop (i + 1) (max n a)

loop 1 0 0 |> printfn "%d"
