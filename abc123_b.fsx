[ for _ in 1..5 do
      yield stdin.ReadLine() |> int ]
|> List.sortByDescending (fun n -> (n - 1) % 10)
|> List.mapi (fun i n ->
    if i < 4 && n % 10 > 0 then
        n + 10 - n % 10
    else
        n)
|> List.sum
|> printfn "%d"
