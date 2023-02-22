let N = stdin.ReadLine() |> int

let [| l; r |] =
    stdin.ReadLine().Split " "
    |> Array.map int
    |> Array.sort
    |> Array.splitInto 2

(if (Array.length l) = (Array.length r) then
     (Array.head r) - (Array.last l)
 else
     0)
|> printfn "%d"
