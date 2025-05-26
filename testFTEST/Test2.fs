namespace testFTEST

open System
open Microsoft.VisualStudio.TestTools.UnitTesting
open TestF



[<TestClass>]
type Test2() =
    [<TestMethod>]
    member this.TestAdd() =
        Assert.AreEqual<int>(3, Think.add 1 2)
        Assert.AreEqual<int>(3, Think.twoPlus 1)

    
