let salaries = [75000; 48000; 120000; 190000; 300113; 92000; 36000]

let updatedSalaries =
    salaries 
    |> List.filter (fun salary -> salary < 49020) 
    |> List.map (fun salary -> salary + 20000)

printfn "Updated salaries (less than $49,020 plus $20,000): %A" updatedSalaries
