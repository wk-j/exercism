module Bob
open System

let isSome = function
    | true -> Some()
    | false -> None

let toChar (input: string) = 
    input.Trim().ToCharArray() |> Seq.filter(fun x -> x <> ' ')

let (|Yell|_|) (input: string) = 
    input 
    |> toChar
    |> Seq.forall (fun x -> (Char.IsUpper(x)  ||  
                                (Char.IsDigit(x) 
                                  || x = '!' 
                                  || x = '?' 
                                  || Char.IsLetterOrDigit(x) |> not
                                  || x = ',')))
    |> isSome

let (|Number|_|) (input:string) = 
    input 
    |> toChar
    |> Seq.forall(fun x -> Char.IsNumber(x) || x = ',')
    |> isSome

let (|Forceful|_|) (input: string) = 
    input 
    |> toChar
    |> Seq.forall(fun x -> Char.IsUpper(x) || x = '?')
    |> isSome

let (|Silence|_|) (input: string) =
    input.Trim() = "" |> isSome

let (|Question|_|) (input: string) = 
    input.Trim().EndsWith("?")
    |> isSome

let response (input: string): string = 
    match input with
    | Silence ->  "Fine. Be that way!"
    | Forceful -> "Whoa, chill out!"
    | Number -> "Whatever."
    | Question -> "Sure."
    | Yell -> "Whoa, chill out!"
    | _ -> "Whatever."
