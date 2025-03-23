[<EntryPoint>]
     let main argv =
         let number = 12345
         
         let result = sum_digits_down number
         printfn "Сумма цифр равна %d" result

         let result = sum_digits_top number
         printfn "Сумма цифр равна %d" result
         0;;

