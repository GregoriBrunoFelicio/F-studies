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

let countUntil n = [1..n] |> printArray

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

let biggest n1 n2 =
        match n1 with
        | n1 when n1 = n2 -> 0
        | n1 when n1 > n2 -> n1
        | _ -> n2

let rec factorial n =
          match n with
          | 0 -> 1
          | 1 -> 1
          | _ -> n * factorial(n-1)


let bind = [1..100] |> List.map(fun x -> x+10) |> List.reduce(fun x y -> x+y) 

type Person = { Name:string; Age:int}

let add (person:Person) = 
        match person with
        | x when x.Age < 18 -> []
        | x -> [x] 

let test (x:string, y:string) =
  if x = y then "equals"
  elif x < y then "is less than"
  else "is greater than"

let IfNormal x =
    if x = 1
    then "é um"
    else "é não"

let paternMatch x =
        match x with
        | 1 -> 1
        | _ -> 0

let print = printf "Ola mundo 1"
            let a = 6666
            printf "%i" a 

[<EntryPoint>]
let main argv =
    print
    0 