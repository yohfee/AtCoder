let S = stdin.ReadLine()

if S.ToCharArray()
   |> Array.distinct
   |> Array.length
   |> (=) S.Length then
    printfn "yes"
else
    printfn "no"
