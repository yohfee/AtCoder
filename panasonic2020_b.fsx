let [| H; W |] = stdin.ReadLine().Split " " |> Array.map int64

(if H = 1L || W = 1L then
     1L
 else
     (W / 2L + W % 2L) * (H / 2L + H % 2L)
     + (W / 2L) * (H / 2L))
|> printfn "%d"
