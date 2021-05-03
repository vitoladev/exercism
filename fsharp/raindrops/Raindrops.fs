module Raindrops


let convert (number: int) : string =
    match number with
    | number when number % 3 = 0 && number % 5 = 0 && number % 7 = 0 -> "PlingPlangPlong"
    | number when number % 3 = 0 && number % 5 = 0 -> "PlingPlang"
    | number when number % 3 = 0 && number % 7 = 0 -> "PlingPlong"
    | number when number % 5 = 0 && number % 7 = 0 -> "PlangPlong"
    | number when number % 3 = 0 -> "Pling"
    | number when number % 5 = 0 -> "Plang"
    | number when number % 7 = 0 -> "Plong"
    | _ -> number.ToString()
