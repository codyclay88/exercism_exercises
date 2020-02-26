module Bob

open System

let (|IsQuestion|_|) (input: string) = 
    if input.EndsWith "?" then 
        Some IsQuestion 
    else None

let (|IsYelling|_|) (input: string) = 
    let letters = 
        input.ToCharArray() 
        |> Array.filter Char.IsLetter
    if (letters.Length <> 0 && Array.forall Char.IsUpper letters) then 
        Some IsYelling 
    else None

let (|IsNothing|_|) (input: string) = 
    if input.Length = 0 then 
        Some IsNothing 
    else None

let response (input: string): string = 
    match input.Trim() with
    | IsNothing -> "Fine. Be that way!"
    | IsYelling & IsQuestion -> "Calm down, I know what I'm doing!"
    | IsYelling -> "Whoa, chill out!"
    | IsQuestion -> "Sure."
    | _ -> "Whatever."  
    