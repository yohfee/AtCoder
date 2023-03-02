let [| x1; y1; x2; y2 |] = stdin.ReadLine().Split " " |> Array.map int

let x3 = x2 - (y2 - y1)
let y3 = y2 + (x2 - x1)
let x4 = x3 - (y3 - y2)
let y4 = y3 + (x3 - x2)

printfn "%d %d %d %d" x3 y3 x4 y4
