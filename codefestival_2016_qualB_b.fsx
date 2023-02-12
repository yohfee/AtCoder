let [| N; A; B |] = stdin.ReadLine().Split " " |> Array.map int
let S = stdin.ReadLine()

let rec loop t b i =
    if i >= N then
        []
    else
        match S.[i] with
        | 'a' when t < A + B -> 1 :: loop (t + 1) b (i + 1)
        | 'b' when t < A + B && b < B -> 1 :: loop (t + 1) (b + 1) (i + 1)
        | _ -> 0 :: loop t b (i + 1)

loop 0 0 0
|> List.iter (fun i -> printfn (if i = 1 then "Yes" else "No"))
