// Learn more about F# at http://fsharp.net. See the 'F# Tutorial' project
// for more guidance on F# programming.

#load "Library1.fs"
open ASimpleSum.FSharp



let square x = x*x;
let sumOfSquares range = 
    range |>
    List.map square |>
    List.sum


sumOfSquares [1..10]

// Define your library scripting code here

