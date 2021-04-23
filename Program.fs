

let calculator (opetation:string, value1:int, value2:int) = 
             match opetation with
             | "" -> printf "Type a value."
             | "+" -> printf "Result: %i" (value1 + value2)
             | "-" -> printf "Result: %i" (value1 - value2)
             | "*" -> printf "Result: %i" (value1 * value2)
             | "/" -> printf "Result: %i" (value1 / value2)
             | _ -> printf "Opetations options: + - / *" 


open System

[<EntryPoint>]
let main argv =
    calculator("/", 123, 5)
    0 