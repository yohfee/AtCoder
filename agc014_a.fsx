let [| A; B; C |] = stdin.ReadLine().Split " " |> Array.map int

let rec loop n a b c =
    if a % 2 = 1 || b % 2 = 1 || c % 2 = 1 then
        n
    elif a = b && b = c then
        -1
    else
        loop (n + 1) ((b + c) / 2) ((a + c) / 2) ((a + b) / 2)

loop 0 A B C |> printfn "%d"
