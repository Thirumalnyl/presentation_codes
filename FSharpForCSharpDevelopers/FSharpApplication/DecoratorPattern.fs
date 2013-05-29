module temp

let addingCalculator input = input + 1
let multiplyingCalc input = input * 5
let subtractingCalculator x y = x -y

let loggingCalculator innerCalculator input = 
   printfn "input is %A" input
   let result = innerCalculator input
   printfn "result is %A" result
   result

let fileLoggingCalculator innerCalculator input = 
   printfn "input is %A" input
   let result = innerCalculator input
   printfn "result is %A" result
   result


let result = loggingCalculator addingCalculator 5

let composedFunc = loggingCalculator addingCalculator

let result2 = fileLoggingCalculator multiplyingCalc 10

let result10 = composedFunc 10

let result5 = composedFunc 5


