using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASimpleSum.Tests
{
    [TestFixture]
    class SumOfSquaresServiceTest
    {
        [Test]
        public void SumOfSquares_SampleRange_CalulatesSum()
        {
            //Arrange
            var service = new SumOfSquaresService();
            var range = Enumerable.Range(1, 10);

            //Act
            var sum = service.SumOfSquares(range);

            //Assert
            Assert.AreEqual(385, sum);
        }

    }
}
