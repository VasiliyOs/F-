module WorkWithDigits
    let sum_digits_top number = 
        let rec sum_digit number cur_sum =
            if number = 0 then cur_sum
            else 
                let last_digit = number % 10
                sum_digit (number / 10) (cur_sum + last_digit)
        sum_digit number 0

    let sum_digits_down number = 
         let rec sum_digit number =
             if number = 0 then 0
             else 
                 let last_digit = number % 10
                 last_digit + sum_digit (number / 10)
         sum_digit number

    let factorial_top number =
        let rec sum_bef number =
            let proiz = number
            if number = 0 then 1
            else
                proiz * sum_bef (number - 1)
        sum_bef number

    let factorial_down number =
        let rec sum_bef number proiz =
            if number = 0 then proiz
            else
                let last = number - 1
                sum_bef (last) (number * proiz)
        sum_bef number 1

    let big_function flag =
        match flag with
            true -> sum_digits_top
            | false -> factorial_top

    let operation_on_digits_numbers number operation initialValue =
        let rec oper num acc =
            if num = 0 then acc
            else
                let lastDigit = num % 10
                oper (num / 10) (operation acc lastDigit)
        oper number initialValue

    let operation_on_digits_numbers_with_condition number operation accum condition =
        let rec oper num acc =
            if num = 0 then acc
            else
                let lastDigit = num % 10
                let newAcc = if condition lastDigit then operation acc lastDigit else acc
                oper (num / 10) newAcc
        oper number accum

    let countVzaimProstDel n =
        obhodProstComp n (fun acc _ -> acc + 1) 0

    let sumDigitsDelOn3 number =
            let rec oper num acc =
                if num = 0 then acc
                else
                    let digit = num % 10
                    if digit % 3 = 0 then
                        oper (num / 10) (acc + digit)
                    else
                        oper (num / 10) acc
            oper number 0

    let countDigits number =
        let rec oper num acc =
            if num = 0 then acc
            else oper (num / 10) (acc + 1)
        oper number 0

    let findCoprimeDivisor number =
        let numDigits = countDigits number
        let rec oper divisor =
            if divisor > number then 1
            else
                if number % divisor = 0 && nod divisor numDigits = 1 then
                    divisor
                else
                    oper (divisor + 1)
        oper 2 
         
    
