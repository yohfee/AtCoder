let [| N; A; B |] = stdin.ReadLine().Split " " |> Array.map int
let S = stdin.ReadLine()

let rec loop a b i =
    if i >= N then
        []
    else
        match S.[i] with
        | 'a' when a + b < A + B -> 1 :: loop (a + 1) b (i + 1)
        | 'b' when a + b < A + B && b < B -> 1 :: loop a (b + 1) (i + 1)
        | _ -> 0 :: loop a b (i + 1)

loop 0 0 0
|> List.iter (fun i -> printfn (if i = 1 then "Yes" else "No"))
