printfn "Hello World"
let solve_result (a, b, c) =
    let D = b * b - 4.0 * a * c
    ((-b + sqrt(D)) / (2.0 * a), (-b - sqrt(D)) / (2.0 * a));

let roots = solve_result (1.0, 2.0, -3.0)

printfn "Корни уравнения: %A" roots
