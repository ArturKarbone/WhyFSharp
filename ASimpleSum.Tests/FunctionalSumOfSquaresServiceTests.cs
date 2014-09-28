using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASimpleSum.Tests
{
    [TestFixture]
    class FunctionalSumOfSquaresServiceTests
    {
        [Test]
        public void SumOfSquares_SampleRange_CalulatesSum()
        {
            //Arrange         
            var service = new FunctionalSumOfSquaresService();
            var range = Enumerable.Range(1, 10);

            //Act
            var sum = service.SumOfSquares(range);

            //Assert
            Assert.AreEqual(385, sum);
        }


        [Test]
        public void SumOfSquares2_SampleRange_CalulatesSum()
        {
            //Arrange         
            var service = new FunctionalSumOfSquaresService();
            var range = Enumerable.Range(1, 10);

            //Act
            var sum = service.SumOfSquares2(range);

            //Assert
            Assert.AreEqual(385, sum);
        }
    }
}
