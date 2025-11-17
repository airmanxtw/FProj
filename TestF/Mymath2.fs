namespace TestF
module Mymath2 =
    open FSharp
    open FSharp.Data
    open FSharpPlus.Data
    let add x y = x + y
    let sub x y = x - y
    let mul x y = x * y
    let div x y = x / y
    let pow x y = pown x y
    let sqrt x = sqrt x
    let log x = log x
    let exp x = exp x
    let sin x = sin x
    let cos x = cos x
    let tan x = tan x   

    let data = [1;2;3;4;5]
    let q =
        query {
            for x in data do
            where(x>2)
            select (x + 1)
        }
        |> fun s -> 
            query {
                for y in s do
                where(y<5)
                select (y * 2)
            }

    let data2 = 
      [Some(3);None;Some(10)]

    let tran1= 
        data2 
        |> List.scan (fun (acc:list<string>) x -> 
            match x with
            | Some v -> acc @ [string v]
            | None -> acc) []
    
    let fn _ = [1..5] |> List.map (fun x -> [1..5] |> List.map (fun y -> x * y))

    let state1  = State(fun s ->(s,s+1))
    let state2  = State(fun s->(s,s*3))

    let stateResult1= State.run (state1 *> state2) 6 |> fun (res,st) -> st

    let stateResult2 = State.bind(fun t->state2) state1 |> State.run <| 6 |> fun (res,st) -> st

    
