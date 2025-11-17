namespace testFTEST

open System
open Microsoft.VisualStudio.TestTools.UnitTesting
open TestF
open Mymath2




[<TestClass>]
type Test1() =

    [<TestMethod>]
    member this.TestMethodPassing() = Assert.AreEqual<int>(3, 2 + 1)

    [<TestMethod>]
    member this.TestMethodListSum() =
        Assert.AreEqual<int>(55, Say.dataListSum)

    [<TestMethod>]
    member this.TestObjName() =
        Assert.AreEqual<string>(
            "Ali",
            Say.GetName
                { StudNo = "1"
                  StudName = "Ali"
                  StudAge = 20 }
        )

    [<TestMethod>]
    member this.TestEx1() =
        Assert.AreEqual<string>("hello, world", Say.Ex1 "world")

    [<TestMethod>]
    member this.TestEx2() =
        Assert.AreEqual<int>(10,Say.Ex2 4 6)

    [<TestMethod>]
    member this.TextEx3() = 
        Assert.AreEqual<string>("普通",Say.Ex3 8 16)
        Assert.AreEqual<string>("吉",Say.Ex3 8 15)
        Assert.AreEqual<string>("大吉",Say.Ex3 8 14)

    [<TestMethod>]
    member this.TestEx4() =
        Assert.AreEqual<string>("平年",Say.Ex4 1977)
        Assert.AreEqual<string>("閏年",Say.Ex4 1980)

    [<TestMethod>]
    member this.TestEx5()=
        Assert.AreEqual<List<int>>([1;2;3;4;5],Say.Ex5 [1;2;3;4])
        Assert.AreEqual<List<int>>([1;3;5;7;9],Say.Ex5 [1;3;5;7])
        Assert.AreEqual<List<int>>([1;2;4;8;16],Say.Ex5 [1;2;4;8])

    // 求二元一次方程式的解
    member this.TestEx6()=
        Assert.AreEqual<List<float>>([2.0;-5.0],Say.Ex6 1.0 3.0 -10.0)
        Assert.AreEqual<List<float>>([0.0],Say.Ex6 1.0 0.0 0.0)
        Assert.AreEqual<List<float>>([],Say.Ex6 1.0 1.0 1.0)

    member this.TestEx7()=
        Assert.AreEqual<string>("*CDC is the trademark of the Control Data Corporation.",Say.Ex7 "1JKJ'pz'{ol'{yhklthyr'vm'{ol'Jvu{yvs'Kh{h'Jvywvyh{pvu5")
        Assert.AreEqual<string>("*IBM is a trademark of the International Business Machine Corporation.",Say.Ex7 "1PIT'pz'h'{yhklthyr'vm'{ol'Pu{lyuh{pvuhs'I|zpulzz'Thjopul'Jvywvyh{pvu5")

    // 因數分解
    member this.TestEx8()=
        Assert.AreEqual<List<int>>([2;2;5],Say.Ex8 20)
        Assert.AreEqual<List<int>>([17],Say.Ex8 17)
        Assert.AreEqual<List<int>>([757 ;1321],Say.Ex8 999997)

    member this.TestReult()=
        Assert.AreEqual<int>(15,Say.funResult1 1 2)

    [<TestMethod>]
    member this.TestStateResult() = 
        let result = stateResult1
        Assert.AreEqual<int>(21,result)

    [<TestMethod>]
    member this.TestStateResult2() = 
        let result = stateResult2
        Assert.AreEqual<int>(21,result)
      


   