using Microsoft.VisualStudio.TestTools.UnitTesting;
using NaturalLanguage.BusinessLogic;

namespace NaturalLanguage.Test
{
    [TestClass]
    public class NaturalLanguageTest
    {
        [TestMethod]
        public void TestCalculateMethod()
        {
            // Arrange
            var expression = "ten pLus fiVe";
            ICalculatorBl bl = new CalculatorBl();

            // Act
            var actual = bl.Calculate(expression);

            // Assert
            Assert.AreEqual(15, actual);
        }
    }
}
