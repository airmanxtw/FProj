namespace TestF



module Say =
    open System
    open FSharpx
    open FSharpx.Result
    let hello name = printfn "Hello %s" name

    let add x y = x + y


    let test x = Mymath2.tan x

    let dataListSum = seq { for i in 1..10 -> i } |> Seq.sum



    let GetName s = s.StudName

    let Ex1 name = sprintf "hello, %s" name

    let Ex2 x y = x + y

    let Ex3 x y =
        match (x * 2 + y) % 3 with
        | 0 -> "大吉"
        | 1 -> "吉"
        | 2 -> "普通"
        | _ -> "未知"

    let Ex4 year =
        if year % 4 = 0 && year % 100 <> 0 || year % 400 = 0 then
            "閏年"
        else
            "平年"

    let Ex5 (nums: List<int>) = 
        if nums.Length < 2 then
            failwith "List must contain at least two elements."        
        let d = nums.Item(1) - nums.Item(0)        
        let isd = 
            nums
            |> List.pairwise
            |> List.forall (fun (x, y) -> y - x = d)
        let b : int = nums.Item(1)/ nums.Item(0)
        let isb = 
            nums
            |> List.pairwise
            |> List.forall (fun (x, y) -> y / x = b)
        if isd then
            [for i in 0..nums.Length -> if i=0 then nums.Item(i) else nums.Item(i-1) + d]
        elif isb then
            [for i in 0..nums.Length -> if i=0 then nums.Item(i) else nums.Item(i-1) * b]
        else []

    // 求二元一次方程式的解    
    let Ex6 a b c =
        let delta = b * b - 4.0 * a * c
        match delta with
        | d when d > 0.0 ->
            let sqrtD = sqrt d
            [(-b + sqrtD) / (2.0 * a); (-b - sqrtD) / (2.0 * a)]
        | d when d = 0.0 ->
            [ -b / (2.0 * a) ]
        | _ -> []

    // 將字串轉為ascii碼
    let Ex7 str :string = String.map (fun c -> char (int c - 14)) str

    let Ex8 (x:int) = 
        let rec factors n i acc =
            if i * i > n then
                if n > 1 then n :: acc else acc
            elif n % i = 0 then
                factors (n / i) i (i :: acc)
            else
                factors n (i + 1) acc
        factors x 2 [] |> List.rev

    let Ex9 n = Ok(n+1)

    let ex9_2Result: Result<int, string> = Ex9 10 |> Result.bind (fun x ->
        Ex9 20 |> Result.map (fun y -> x + y))

    let ex9Result : Result<int, string> =
        result {
            let! x = Ex9 10
            let! y = Ex9 20
            return x + y
        }
    
    let fun1 x = x*3;
    let fun2 y = y+10;

    let funResult1 x y = 
        fun1 x |> fun z -> fun2 y |> fun w -> z +  w;

    let funReulst2 x y =
        let z = fun1 x
        let w = fun2 y
        z +  w