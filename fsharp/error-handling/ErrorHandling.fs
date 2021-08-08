module ErrorHandling

open System

let handleErrorByThrowingException () = failwith "error"

let handleErrorByReturningOption (input: string) =
    let success, number = Int32.TryParse input
    if success then Some number else None

let handleErrorByReturningResult (input: string) =
    let success, number = Int32.TryParse input

    if success then
        Ok number
    else
        Error "Could not convert input to integer"

let bind switchFunction twoTrackInput =
    match twoTrackInput with
    | Ok n -> switchFunction n
    | _ -> twoTrackInput

let cleanupDisposablesWhenThrowingException resource =
    using resource (fun _ -> failwith "error")
