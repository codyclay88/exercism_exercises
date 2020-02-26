module SumOfMultiples

let getMultiplesOfUntil upperBound num =
    if num > upperBound then [0]
    else 
        [1..upperBound]
        |> List.map (fun x -> x * num)
        |> List.filter (fun x -> x < upperBound)    
        
let sum (numbers: int list) (upperBound: int): int = 
    numbers
    |> List.collect (getMultiplesOfUntil upperBound)
    |> List.distinct
    |> List.sum