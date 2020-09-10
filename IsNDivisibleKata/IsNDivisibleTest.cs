using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IsNDivisibleKata
{
    [TestClass]
    public class IsNDivisibleTest
    {
        [TestMethod]
        public void GivenTwoNumbers_ReturnIfNIsDivisible()
        {
            //arrange
            var n = 3;
            var x = 1;
;           var y = 3;
            var expectedResult = true;

            //act
            var actualResult = Calculate.IsNDivisible(n, x, y);

            //assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void GivenASecondSetOfTwoNumbers_ReturnIfNIsDivisible()
        {
            //arrange
            var n = 100;
            var x = 5;
            var y = 3;
            var expectedResult = false;

            //act
            var actualResult = Calculate.IsNDivisible(n, x, y);

            //assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
