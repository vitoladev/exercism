module RnaTranscription

let toRna (dna: string) : string =
    let convertChar char =
        match char with
        | 'G' -> 'C'
        | 'C' -> 'G'
        | 'T' -> 'A'
        | 'A' -> 'U'
        | _ -> char

    dna |> String.map (convertChar)
