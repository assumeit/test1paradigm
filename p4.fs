let salaries = [75000; 48000; 120000; 190000; 300113; 92000; 36000]

let sumOfSalariesInRange =
    salaries 
    |> List.filter (fun salary -> salary >= 50000 && salary <= 100000) 
    |> List.fold (+) 0

printfn "Sum of salaries between $50,000 and $100,000: %d" sumOfSalariesInRange
