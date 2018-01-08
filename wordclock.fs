open System

let curTime = DateTime.Now

printfn "%A" curTime 

let timeMap = 
    function
    | "1" -> "one"
    | "2" -> "two"
    | "3" -> "three"
    | "4" -> "four"
    | "5" -> "five"
    | "6" -> "six"
    | "7" -> "seven"
    | "8" -> "eight"
    | "9" -> "nine"
    | "0" -> "oh"
    | _ -> failwith "no way\n"

// timeMap curTime
// test
// test2
// test3
let toEng = String.map timeMap