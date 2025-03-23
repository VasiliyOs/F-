let solve_result (a, b, c) =
    let D = b * b - 4.0 * a * c
    ((-b + sqrt(D)) / (2.0 * a), (-b - sqrt(D)) / (2.0 * a));
    
let circle_s radius =
    System.Math.PI * radius * radius

let cyl_vol_super (radius, height) = 
    let cylinder_base_s = 
        circle_s radius
    height * cylinder_base_s

let cyl_vol_car radius height =
    let cylinder_base_s = 
        circle_s radius
    height * cylinder_base_s

[<EntryPoint>]
let main (args : string[]) =
    let roots = solve_result (1.0, 2.0, -3.0)
    
    printfn "Введите радиус и высоту:"
    let radius = float (System.Console.ReadLine())
    let height = float (System.Console.ReadLine())

    let circle_s = circle_s radius
    printfn "Площадь круга: %f" circle_s

    let vol_super = cyl_vol_super (radius, height)
    printfn "Объем цилиндра суперпоз: %f" vol_super
    
    let vol_car = cyl_vol_car radius height
    printfn "Объем цилиндра кариров: %f" vol_car
    
    let number = 12345
    let result = WorkWithDigits.sum_digit_recursion_top number
    printfn "Сумма цифр равна %d" result
    
    0

