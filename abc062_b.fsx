let [| H; W |] = stdin.ReadLine().Split() |> Array.map int

let h = String.replicate W "#"

[ yield h
  for _ in 1..H do
      yield stdin.ReadLine().Trim()
  yield h ]
|> List.iter (printfn "#%s#")
