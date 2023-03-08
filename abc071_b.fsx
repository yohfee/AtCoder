let S = stdin.ReadLine().ToCharArray()

[ 'a' .. 'z' ]
|> List.tryFind (fun c -> Array.contains c S |> not)
|> Option.map string
|> Option.defaultValue "None"
|> printfn "%s"
