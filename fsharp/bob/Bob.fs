module Bob

open System
open System.Text.RegularExpressions

let isUppercase input =
    Regex.Match(input, "[A-Z]").Success
    && not (Regex.Match(input, "[a-z]").Success)

let isQuestion (input: string) = input.TrimEnd().EndsWith("?")

let isUppercaseWithQuestion input = isUppercase input && isQuestion input

let isInvalid (input: string) =
    String.IsNullOrEmpty input
    || String.IsNullOrWhiteSpace input

let response (input: string) : string =

    match input with
    | input when isUppercaseWithQuestion input -> "Calm down, I know what I'm doing!"
    | input when isUppercase input -> "Whoa, chill out!"
    | input when isQuestion input -> "Sure."
    | input when isInvalid input -> "Fine. Be that way!"
    | _ -> "Whatever."
