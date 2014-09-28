namespace ASimpleSum.FSharp.Tests

module SumOfSquaresServiceTests=

    open NUnit.Framework
    open ASimpleSum.FSharp

    [<TestFixture>]
    type SumOfSquaresServiceTests() = 

        [<Test>]
        member this.SumOfSquares_SampleRange_CalulatesSum() = 
            let range = [1..10]
            let sumOfSquares = SumOfSquaresService.sumOfSquares range;        
            Assert.AreEqual(385,sumOfSquares)

    [<Test>]
    let ``SumOfSquares should calcuate right sum``() = 
        let range = [1..10]
        let sumOfSquares = SumOfSquaresService.sumOfSquares range;        
        Assert.AreEqual(385,sumOfSquares)
        

