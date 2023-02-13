let [| H; W |] = stdin.ReadLine().Split " " |> Array.map int64

(if H = 1L || W = 1L then
     1L
 else
     H * W / 2L + H * W % 2L)
|> printfn "%d"
