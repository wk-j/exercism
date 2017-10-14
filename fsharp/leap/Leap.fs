module Leap

let (|DivBy|_|) divisor i  =
    if i % divisor = 0 
        then Some()
    else None

let leapYear (year: int): bool =
    match year with
    | DivBy 100 | DivBy 400 -> false
    | DivBy 4 -> true
    | _ -> false

