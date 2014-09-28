namespace ASimpleSum.FSharp
module SumOfSquaresService =
    let square x = x*x;
    let sumOfSquares range = 
        range |>
        List.map square |>
        List.sum



type Class1() = 
    member this.X = "F#"
   