(* Get the system time and read it back in English
   eg., "Three oh five."
*)

open System

//let curTime = DateTime.Now
let curTime = "2"

//printfn "%A" curTime //tmp

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
printfn "%s" <| (String.map timeMap curTime )