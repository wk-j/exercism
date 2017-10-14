module Leap

let (|DivBy|_|) divisor i  =
    if i % divisor = 0 
        then Some()
    else None

let leapYear (year: int): bool =
    match year with
    | DivBy 4 & (DivBy 100 | DivBy 400) -> true
    | _ -> false

