let N = stdin.ReadLine() |> int

let A =
    [ for i in 1..N do
          yield i, stdin.ReadLine() |> int ]
    |> List.sortByDescending snd

[ 1..N ]
|> List.iter (fun i ->
    A
    |> List.find (fst >> (<>) i)
    |> snd
    |> printfn "%d")
