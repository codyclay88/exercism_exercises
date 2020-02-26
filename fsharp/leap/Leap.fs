module Leap

let leapYear (year: int): bool = 
    let divBy4   = year % 4 = 0
    let divBy100 = year % 100 = 0
    let divBy400 = year % 400 = 0

    divBy4 && (not divBy100 || divBy400)

