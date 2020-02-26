module Grains

let calcSquareVal n = 
    match n with
    | 1 -> Ok (uint64 1)
    | 2 -> Ok (uint64 2)
    | n when n > 2 && n < 65 -> Ok(uint64((n-1) * 2))
    | _ -> Error "Blah"

let square (n: int): Result<uint64,string> =
    n |> calcSquareVal  
    

let total: Result<uint64,string> = failwith "Blah"
    // Seq.sumBy square [1..n]
    // |> Seq.toList