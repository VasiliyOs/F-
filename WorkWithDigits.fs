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
