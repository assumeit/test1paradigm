let sumOfMultiplesOf3 (n: int) =
    let rec helper (current: int) (acc: int) =
        if current <= 0 then acc
        else helper (current - 3) (acc + current)
    helper n 0

let result = sumOfMultiplesOf3 27
printfn "The sum of all multiples of 3 up to 27 is %d" result
