module SpaceAge

type Planet = Earth | Mercury | Venus | Mars | Jupiter | Saturn | Uranus | Neptune

let earthSecondsToAge seconds =
    let secondsInDay = 86400.0
    let daysInYear = 365.25
    seconds / secondsInDay / daysInYear

let convertToEarthSeconds planet seconds =
    let convert conversionValue = seconds / conversionValue 
    match planet with
    | Earth -> seconds
    | Mercury -> convert 0.2408467
    | Venus -> convert 0.61519726
    | Mars -> convert 1.8808158
    | Jupiter -> convert 11.862615
    | Saturn -> convert 29.447498
    | Uranus -> convert 84.016846
    | Neptune -> convert 164.79132

let age (planet: Planet) (seconds: int64): float = 
    seconds
    |> float
    |> convertToEarthSeconds planet
    |> earthSecondsToAge