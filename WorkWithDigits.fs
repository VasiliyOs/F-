module WorkWithDigits
    let sum_digit_recursion_top number = 
        let rec sum_digit number cur_sum =
            if number = 0 then cur_sum
            else 
                let last_digit = number % 10
                sum_digit (number / 10) (cur_sum + last_digit)
        sum_digit number 0