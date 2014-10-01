using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;


namespace Factorial.Tests
{
    [TestFixture]
    public class FactorialServiceTests
    {

    

        static object[] FactorialCases =
        {
            new object[] { 0, new BigInteger(1) },
            new object[] { 1,new BigInteger(1) },
            new object[] { 4,new BigInteger(24) } ,
            new object[] { 10,new BigInteger(3628800) } ,
            new object[] { 15,new BigInteger(1307674368000) } ,
            new object[] { 20,new BigInteger(2432902008176640000) } ,
            new object[] { 10000,new BigInteger(2432902008176640000) } ,

        };

        [Test]       
        [TestCaseSource("FactorialCases")]
        public void Iterative_Calculate_CorrectResult(int n,BigInteger result)
        {
            //Arrange
            IFactorial factorial = new IterativeFactorial();

            //Act/Assert
            Assert.AreEqual(result, factorial.Calculate(n));
        }


        [Test]
        [TestCaseSource("FactorialCases")]
        public void Recursive_Calculate_CorrectResult(int n, BigInteger result)
        {            
            //Arrange
            IFactorial factorial = new RecursiveFactorial();

            //Act/Assert
            Assert.AreEqual(result, factorial.Calculate(n));
        }
    }
}
