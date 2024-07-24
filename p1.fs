let salaries = [75000; 48000; 120000; 190000; 300113; 92000; 36000]

let highIncomeSalaries = 
    List.filter (fun salary -> salary > 100000) salaries

printfn "High income salaries: %A" highIncomeSalaries
