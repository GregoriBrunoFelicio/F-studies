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
        | head::tail -> printf "%A" head
                        printArray tail

let counterUntil n = [1..n] |> printArray

let removeFromArray n array = array |> List.filter(fun x -> x <> n) |> printArray


let rec replaceElementFromArray element newElement array aux =
                        match array with
                        | head::tail when head = element -> aux@[newElement]@tail; 
                        | head::tail -> replaceElementFromArray element newElement tail (aux@[head])
                        | [] ->  aux
    


[<EntryPoint>]
let main argv =
    printf "%A"  (replaceElementFromArray 5 99 [1..100] [])
    0 