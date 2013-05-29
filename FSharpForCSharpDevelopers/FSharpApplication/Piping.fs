module Sample

let result = 
    [1..100] 
        |> List.filter (fun x -> x % 2 = 0) 
        |> List.map (fun x -> x * x) 
        |> Seq.sum     