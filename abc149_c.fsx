let X = stdin.ReadLine() |> int

let p x =
    let rec loop' i =
        x = i || (x > i && x % i <> 0 && loop' (i + 1))

    loop' 2

let rec loop x = if p x then x else loop (x + x % 2 + 1)

loop X |> printfn "%d"
