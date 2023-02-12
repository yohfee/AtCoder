let N = stdin.ReadLine() |> int

let X = N |> float |> (/) <| 1.08

let X' =
    X
    |> int
    |> (+) (if (X |> int |> float < X) then 1 else 0)

let rec loop x =
    match x |> float |> (*) 1.08 |> int with
    | n when n > N -> ":("
    | n when n = N -> sprintf "%d" x
    | _ -> x + 1 |> loop

X' |> loop |> printfn "%s"
