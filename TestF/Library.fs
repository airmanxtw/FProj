namespace TestF



module Say =
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
        let d = nums.Item(1) - nums.Item(0)
        let b = 
            nums
            |> List.pairwise
            |> List.forall (fun (x, y) -> y - x = d)
        if b then
            [for i in 0..nums.Length -> if i=0 then nums.Item(i) else nums.Item(i-1) + d]
        else
            [for i in 0..nums.Length-1 -> nums.Item(i) - d]
        