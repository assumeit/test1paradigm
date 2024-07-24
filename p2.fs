let salaries = [75000; 48000; 120000; 190000; 300113; 92000; 36000]

let calculateTax salary =
    match salary with
    | s when s <= 49020 -> s * 15 / 100
    | s when s <= 98040 -> s * 205 / 1000  // 20.5%
    | s when s <= 151978 -> s * 26 / 100
    | s when s <= 216511 -> s * 29 / 100
    | _ -> salary * 33 / 100

let taxes = 
    salaries 
    |> List.map calculateTax

printfn "Taxes for all salaries: %A" taxes
