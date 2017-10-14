module Leap

let (|DivBy|_|) divisor i  =
    if i % divisor = 0 
        then Some()
    else None

let (|NotDivBy|_|) divisor i  =
    if i % divisor = 0 
        then None
    else Some()


let leapYear (year: int): bool =
    match year with
    | DivBy 400 -> true
    | DivBy 4 & NotDivBy 100 -> true
    | _ -> false

