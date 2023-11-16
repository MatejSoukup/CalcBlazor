using CalcBlazor.Services;

namespace CalculatorTests
{
    [TestClass]
    public class CalculatorServiceTests
    {
        [TestMethod]
        public void AddTest()
        {
            //Arrange
            decimal numberA = 1;
            decimal numberB = 2;
            CalculatorService calculator = new CalculatorService();

            //Act
            decimal? actual = calculator.Add(numberA, numberB);

            //Assert
            decimal expectedNum = 3;
            Assert.AreEqual(expectedNum, actual, "Numbers not added correctly");
        }

        [TestMethod]
        public void SubtractTest()
        {
            // Arrange
            decimal numberA = 5;
            decimal numberB = 2;
            CalculatorService calculator = new CalculatorService();

            // Act
            decimal? actual = calculator.Subtract(numberA, numberB);

            // Assert
            decimal expectedNum = 3;
            Assert.AreEqual(expectedNum, actual, "Numbers not subtracted correctly");
        }
        [TestMethod]
        public void MultiplyTest()
        {
            // Arrange
            decimal numberA = 4;
            decimal numberB = 3;
            CalculatorService calculator = new CalculatorService();

            // Act
            decimal? actual = calculator.Multiply(numberA, numberB);

            // Assert
            decimal expectedNum = 12;
            Assert.AreEqual(expectedNum, actual, "Numbers not multiplied correctly");
        }

        [TestMethod]
        public void DivideTest()
        {
            // Arrange
            decimal numberA = 10;
            decimal numberB = 2;
            CalculatorService calculator = new CalculatorService();

            // Act
            decimal? actual = calculator.Divide(numberA, numberB);

            // Assert
            decimal expectedNum = 5;
            Assert.AreEqual(expectedNum, actual, "Numbers not divided correctly");
        }


    }
}