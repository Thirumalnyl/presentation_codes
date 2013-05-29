module romanDigit

type RomanDigit = I | V | X | L | C | D | M
type RomanNumeral = RomanNumeral of RomanDigit list 

/// Converts a single RomanDigit to an integer
let digitToInt =
    function
    | I -> 1
    | V -> 5
    | X -> 10
    | L -> 50
    | C -> 100
    | D -> 500
    | M -> 1000

let rec digitsToInt =
    function
        
    // empty is 0
    | [] -> 0

    // special case when a smaller comes before larger
    // convert both digits and add the difference to the sum 
    // Example: "IV" and "CM"
    | smaller::larger::ns when smaller < larger -> 
        (digitToInt larger - digitToInt smaller)  + digitsToInt ns

    // otherwise convert the digit and add to the sum 
    | digit::ns -> 
        digitToInt digit + digitsToInt ns

// tests
let result1 = [I;I;I;I]  |> digitsToInt // 4
let result2 = [I;V]  |> digitsToInt // 4
let result3 = [V;I]  |> digitsToInt // 6
let result4 = [I;X]  |> digitsToInt // 9
let result5 = [M;C;M;L;X;X;I;X]  |> digitsToInt // 1979
let result6 = [M;C;M;X;L;I;V] |> digitsToInt // 1944