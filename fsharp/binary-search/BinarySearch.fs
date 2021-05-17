module BinarySearch



let rec search (input: int [], value: int, startIndex: int, endIndex: int) =
    try
        let averageIndex = (startIndex + endIndex) / 2
        let average = input.[averageIndex]

        if startIndex <= endIndex then
            match average with
            | average when average = value -> Some averageIndex
            | average when average > value -> search (input, value, startIndex, averageIndex - 1)
            | average when average < value -> search (input, value, averageIndex + 1, endIndex)
            | _ -> None
        else
            None
    with :? System.IndexOutOfRangeException -> None

let find (input: int []) value =
    let startIndex = 0
    let endIndex = input.Length - 1
    search (input, value, startIndex, endIndex)
