stdin.ReadLine().ToCharArray()
|> Array.windowed 3
|> Array.map (
    Array.map string
    >> Array.reduce (+)
    >> int
    >> (-) 753
    >> abs
)
|> Array.min
|> printfn "%d"
