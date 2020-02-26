module Raindrops

let convert (number: int): string = 
    let isFactor num = number % num = 0

    let resolveIfEmpty (str: string) = 
        if str.Length = 0 then (string number) 
        else str
    
    [(3, "Pling"); (5, "Plang"); (7, "Plong")]
    |> List.map (fun (num, str) -> if isFactor num then str else "")
    |> List.reduce (+)
    |> resolveIfEmpty