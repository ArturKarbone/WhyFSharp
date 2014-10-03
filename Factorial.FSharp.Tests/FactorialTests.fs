namespace Fatorial.Fsharp.Tests
module FactorialTests=
    
    open NUnit.Framework 
    open Factorial.FSharp    

     type FactorialCase = 
        { N: int;   Result: bigint }

    //Arrays

    //http://msdn.microsoft.com/en-us/library/dd233214.aspx

    //literals
    //http://msdn.microsoft.com/en-us/library/dd233193.aspx
    let FactorialCases =         
         [|            
            [|{ N = 0; Result=bigint(1) };|]
            [|{ N = 1; Result=bigint(1) };|]
            [|{ N = 4; Result=bigint(24) };|]
            [|{ N = 10; Result=bigint(3628800) };|]
            [|{ N = 15; Result=1307674368000I };|]
            [|{ N = 20; Result=2432902008176640000I };|]
            [|{ N = 92; Result=12438414054641307255475324325873553077577991715875414356840239582938137710983519518443046123837041347353107486982656753664000000000000000000000I  };|]            
         |]

    [<Test>]
    [<TestCaseSource("FactorialCases")>] 
    let ``Should calcuate right factorial`` (testCase) =       
        let factorial = Factorial.calculate testCase.N
        Assert.AreEqual(testCase.Result,factorial)

    [<Test>]
    [<TestCaseSource("FactorialCases")>]
    let ``Should calculate right factorial for pattern matching approach`` (testCase) =
        let factorial = Factorial.calcuateWithPatternMatching testCase.N
        Assert.AreEqual(testCase.Result,factorial)


    
    [<Test>]
    [<TestCaseSource("FactorialCases")>]
    let ``Should calculate right factorial for pattern matching approach 2`` (testCase) =
        let factorial = Factorial.calcuateWithPatternMatching2 testCase.N
        Assert.AreEqual(testCase.Result,factorial)
