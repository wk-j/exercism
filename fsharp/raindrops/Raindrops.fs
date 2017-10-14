module Raindrops

let (|DivBy|_|) divisor i  =
    if i % divisor = 0 
        then Some()
    else None

let convert (number: int): string = 
    let rec find x = 
        match x with
        | DivBy 3 -> "Pling" :: find (x / 3)
        | DivBy 5 -> "Plang" :: find (x / 5)
        | DivBy 7 -> "Plong" :: find (x / 7)
        | _ -> []
    let rs = find number |> List.groupBy(id) |> List.map (fst) |> String.concat ""
    if rs = "" then string number else rs

