let [| a; b |] = stdin.ReadLine().Split " " |> Array.map int

(if a > 0 then "Positive"
 elif a <= 0 && b >= 0 then "Zero"
 elif (b - a) % 2 = 0 then "Negative"
 else "Positive")
|> printfn "%s"
