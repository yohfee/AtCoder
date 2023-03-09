let [| N; K; Q |] = stdin.ReadLine().Split " " |> Array.map int

let a i =
    Map.tryFind i >> Option.defaultValue 0 >> (+) 1

let rec loop i p =
    if i = Q then
        p
    else
        let n = stdin.ReadLine() |> int
        p |> Map.add n (a n p) |> loop (i + 1)

let P = Map.empty |> loop 0

let f a =
    Map.tryFind a P |> Option.defaultValue 0 > Q - K

for i in 1..N do
    printfn (if f i then "Yes" else "No")
