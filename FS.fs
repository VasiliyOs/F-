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
    printfn "Введите радиус и высоту:"
    let radius = float (System.Console.ReadLine())
    let height = float (System.Console.ReadLine())

    let circle_s = circle_s radius
    printfn "Площадь круга: %f" circle_s

    let vol_super = cyl_vol_super (radius, height)
    printfn "Объем цилиндра суперпоз: %f" vol_super
    
    let vol_car = cyl_vol_car radius height
    printfn "Объем цилиндра кариров: %f" vol_car

    0