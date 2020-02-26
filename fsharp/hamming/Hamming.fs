module Hamming

// let rec compareDNA strand1 strand2 distanceCount =
//     match (strand1, strand2) with
//     | ([], []) -> distanceCount
//     | (s1_head :: s1_tail, s2_head :: s2_tail) when s1_head <> s2_head -> compareDNA s1_tail s2_tail (distanceCount + 1) 
//     | (s1, s2) -> compareDNA s1.Tail s2.Tail distanceCount

let distance (strand1: string) (strand2: string): int option = 
    if strand1.Length <> strand2.Length then None
    else 
        Seq.zip strand1 strand2
        |> Seq.filter (fun (x, y) -> x <> y)
        |> Seq.length
        |> Some