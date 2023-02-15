let A =
    [ for _ in 0..2 do
          yield! stdin.ReadLine().Split " " |> Array.map int ]

let N = stdin.ReadLine() |> int

let B =
    0
    |> Seq.unfold (fun n ->
        if n = N then
            None
        else
            Some(stdin.ReadLine() |> int, n + 1))
    |> List.ofSeq

let (!) f a b = f b a

let r =
    [ [ A.[0]; A.[1]; A.[2] ]
      [ A.[3]; A.[4]; A.[5] ]
      [ A.[6]; A.[7]; A.[8] ]
      [ A.[0]; A.[3]; A.[6] ]
      [ A.[1]; A.[4]; A.[7] ]
      [ A.[2]; A.[5]; A.[8] ]
      [ A.[0]; A.[4]; A.[8] ]
      [ A.[2]; A.[4]; A.[6] ] ]
    |> List.exists (
        ! List.except B
        >> (List.length >> (=) (List.length B - 3))
    )

printfn "%s" (if r then "Yes" else "No")
