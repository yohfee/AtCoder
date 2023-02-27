let r () =
    stdin.ReadLine().Split " " |> Array.map int

let [| A; B; M |] = r ()
let a = r ()
let b = r ()

(Array.min a + Array.min b)
:: [ for _ in 1..M do
         let [| x; y; c |] = r ()
         yield a.[x - 1] + b.[y - 1] - c ]
|> List.min
|> printfn "%d"
