module CollatzConjecture

let rec usedSteps (number: int) (takenSteps: int) =
    match number with
    | number when number % 2 = 0 -> usedSteps (number / 2) (takenSteps + 1)
    | number when number = 1 -> Some(takenSteps)
    | number when number % 1 = 0 -> usedSteps ((number * 3) + 1) (takenSteps + 1)
    | _ -> None

let steps (number: int) : int option =
    if number < 1 then
        None
    else
        usedSteps number 0
