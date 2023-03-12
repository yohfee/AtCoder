stdin.ReadLine().ToCharArray()
|> Array.countBy id
|> Array.forall (fun n -> snd n % 2 = 0)
|> fun b -> printfn (if b then "Yes" else "No")
