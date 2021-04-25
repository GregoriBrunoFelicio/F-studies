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

let rec replaceElementFromArrayUsingRecursion element newElement array aux =
                        match array with
                        | head::tail when head = element -> aux@[newElement]@tail; 
                        | head::tail -> replaceElementFromArrayUsingRecursion element newElement tail (aux@[head])
                        | [] ->  aux

let replaceElementFromArray element newElement array = array |> List.map (fun x -> match x with
                                                                                   | x when x = element -> newElement
                                                                                   | element -> element)


let rec arraySize array size = 
                match array with
                | [] -> 0
                | head::tail -> arraySize tail size+1
                
let arrayContains array element = array |> List.filter (fun x -> x = element) |> List.length > 0


[<EntryPoint>]
let main argv =
    printf "%A" (replaceElementFromArray 1 22 [1..10] )
    0 