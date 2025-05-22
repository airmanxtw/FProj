namespace testFTEST

open System
open Microsoft.VisualStudio.TestTools.UnitTesting
open TestF


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
    member this.TextEx4() =
        Assert.AreEqual<string>("平年",Say.Ex4 1977)
        Assert.AreEqual<string>("閏年",Say.Ex4 1980)

    


   