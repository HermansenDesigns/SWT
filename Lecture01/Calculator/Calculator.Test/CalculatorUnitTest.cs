using System;
using Xunit;

namespace Calculator.Test
{
    public class CalculatorUnitTest
    {
        private Calculator calc = new Calculator();

        [Fact]
        public void Calculator_Addition_SimpleValues_Calculated()
        {
            // Arrange
            double a = 1, b = 2;
            double expected = 3;
            // Act
            double actual = calc.Add(a, b);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Calculator_Subtraction_SimpleValues_Calculated()
        {
            // Arrange
            double a = 1, b = 2;
            double expected = -1;
            // Act
            double actual = calc.Subtract(a, b);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Calculator_Multiplication_SimpleValues_Calculated()
        {
            // Arrange
            double a = 2, b = 3;
            double expected = 6;
            // Act
            double actual = calc.Multiply(a, b);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Calculator_Power_SimpleValues_Calculated()
        {
            // Arrange
            double x = 2, exp = 3;
            double expected = 8;
            // Act
            double actual = calc.Power(x, exp);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Calculator_Power_x_is_0_Calculated()
        {
            // Arrange
            double x = 0, exp = 3;
            double expected = 0;
            // Act
            double actual = calc.Power(x, exp);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Calculator_Power_exp_is_0_Calculated()
        {
            // Arrange
            double x = 2, exp = 0;
            double expected = 1;
            // Act
            double actual = calc.Power(x, exp);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
