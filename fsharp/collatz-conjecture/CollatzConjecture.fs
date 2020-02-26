module CollatzConjecture 

let rec step number count =
    if number = 1 then count
    else if number % 2 = 0 then step (number / 2) (count + 1)
    else step ((3 * number) + 1) (count + 1)

let steps (number: int): int option = 
    if number > 0 then Some (step number 0)
    else None   
