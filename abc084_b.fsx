let [| A; B |] = stdin.ReadLine().Split " " |> Array.map int
let S = stdin.ReadLine()

let d s = s >= '0' && s <= '9'

S.ToCharArray()
|> Array.indexed
|> Array.forall (fun (i, s) ->
    (i < A && d s)
    || (i = A && s = '-')
    || (i > A && i <= A + B && d s))
|> (fun r -> if r then "Yes" else "No")
|> printfn "%s"
