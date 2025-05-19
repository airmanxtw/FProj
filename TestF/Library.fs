namespace TestF



module Say =
    let hello name = printfn "Hello %s" name

    let add x y = x + y


    let test x = Mymath2.tan x

    let dataListSum = seq { for i in 1..10 -> i } |> Seq.sum

    

    let GetName  s = s.StudName

    let Ex1 name = sprintf "hello, %s" name

    let Ex2 x y = x + y
       
    let Ex3 x y =
        match (x*2+y) % 3 with
        | 0 -> "大吉"
        | 1 -> "吉"
        | 2 -> "普通"
        | _ -> "未知"