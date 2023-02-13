let gets () =
    stdin.ReadLine().Split " " |> Array.map int

let [| N; M; C |] = gets ()
let B = gets ()

let loop gets =
    let (*) (a, b) = a * b

    let rec loop' i r =
        if i = N then
            r
        else
            let p =
                gets ()
                |> Array.zip B
                |> Array.map (*)
                |> Array.sum
                |> (<) -C

            loop' (i + 1) (if p then r + 1 else r)

    loop'

loop gets 0 0 |> printfn "%d"
