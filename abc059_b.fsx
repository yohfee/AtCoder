let A = stdin.ReadLine() |> float
let B = stdin.ReadLine() |> float

printfn (
    if A > B then "GREATER"
    elif A < B then "LESS"
    else "EQUAL"
)
