namespace CalculatorApp.XUnitTests
{
    public class CalculatorTests
    {

      


        [Theory]
        [InlineData(5,4,9)]
        [InlineData(-1,-4,-5)]
        [InlineData(3.5,1.9,5.4)]
        [InlineData(1,0,1)]
        [InlineData(7,3,10)]
        public void Add_ShouldReturnCorrectResult(double num1, double num2, double expected)
        {
            //Arrange
            var calculator = new Calculator();
            //Act
            var result = calculator.Add(num1, num2);
            //Assert
            Assert.Equal(expected, result);
        }


        [Theory]
        [InlineData(5, 4, 1)]
        [InlineData(-1, -4, 3)]
        [InlineData(3.5, 1.9, 1.6)]
        [InlineData(1, 0, 1)]
        [InlineData(7, 3, 4)]
        public void Substract_ShouldReturnCorrectResult(double num1, double num2, double expected)
        {
            //Arrange
            var calculator = new Calculator();
            //Act
            var result = calculator.Subtract(num1, num2);
            //Assert
            Assert.Equal(expected, result);
        }


        [Theory]
        [InlineData(5, 4, 20)]
        [InlineData(-1, -4, 4)]
        [InlineData(3.5, 2, 7)]
        [InlineData(1, 1, 1)]
        [InlineData(7, 3, 21)]
        public void Multiply_ShouldReturnCorrectResult(double num1, double num2, double expected)
        {
            //Arrange
            var calculator = new Calculator();
            //Act
            var result = calculator.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected, result);
        }


        [Theory]
        [InlineData(5, 4, 1.25)]
        [InlineData(-10, -4, 2.5)]
        [InlineData(3, 2, 1.5)]
        [InlineData(1, 1, 1)]
        [InlineData(9, 3, 3)]
        public void Divide_ShouldReturnCorrectResult(double num1, double num2, double expected)
        {
            //Arrange
            var calculator = new Calculator();
            //Act
            var result = calculator.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, result);
        }



        [Fact]
        public void Divide_ByZero_ShouldThrowDivideByZeroException()
        {
            var calculator = new Calculator();

            Assert.Throws<DivideByZeroException>(() => calculator.Divide(1, 0));
        }

    }
}