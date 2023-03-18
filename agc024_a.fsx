let [| A; B; C; K |] = stdin.ReadLine().Split " " |> Array.map int64

printfn "%d" (if K % 2L = 0L then A - B else B - A)
