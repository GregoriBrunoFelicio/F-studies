open System

type Operation =
           | Add 
           | Subtract 
           | Multiply 
           | Divide   


let sum (n1:int, n2:int) = n1 + n2
let sub (n1:int, n2:int) = n1 - n2
let multiply (n1:int, n2:int) = n1 * n2
let div (n1:int, n2:int) = n1 / n2


let calculator (opetation:Operation, value1:int, value2:int) = 
             match opetation with
             | Operation.Add -> "Result:" + sum(value1, value2).ToString()
             | Operation.Subtract -> "Result:" + sub(value1, value2).ToString()
             | Operation.Multiply -> "Result:" + multiply(value1, value2).ToString()
             | Operation.Divide -> "Result:" + div(value1, value2).ToString()


let rec printArray array = 
        match array with
        | [] -> ()
        | head::tail -> printf "%i" head
                        printArray tail

let counterUntil n = [1..n] |> printArray

let removeFromArray n array = array |> List.filter(fun x -> x <> n) |> printArray


[<EntryPoint>]
let main argv =
    counterUntil 10

    0 