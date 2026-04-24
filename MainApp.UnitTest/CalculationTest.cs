using System;
using System.Collections.Generic;
using System.Text;

using MainApp.Services;

namespace MainApp.UnitTest
{
    public class CalculationTest
    {
        [Fact]
        public void Sum_Static_Test_Success()
        {
            Calculation calc = new Calculation();
            
            int a = 5;
            int b = 7;

            var result = calc.Sum(a, b);

            Assert.Equal(12, result);
            Assert.NotEqual(14, result);
        }

        [Fact]
        public void Subract_Correct_Returns_Success()
        {
            Calculation calc = new Calculation();

            int a = 17;
            int b = 4;

            var result = calc.Subtract(a, b);

            Assert.Equal(13, result);
            Assert.NotEqual(15, result);
        }

        [Fact]
        public void Multiply_Correct_Returns_Success()
        {
            Calculation calc = new Calculation();

            int a = 3;
            int b = 5;

            var result = calc.Multiply(a, b);

            Assert.Equal(15, result);
            Assert.NotEqual(13, result);
        }

        [Fact]
        public void Divide_Correct_Returns_Success()
        {
            Calculation calc = new Calculation();

            int a = 13;
            int b = 4;

            var result = calc.Divide(a, b);

            Assert.Equal(3, result);
            Assert.NotEqual(2, result);
        }

        [Fact]
        public void Divide_With_Zero_Throws_DivideByZeroException()
        {
            Calculation calc = new Calculation();

            Assert.Throws<DivideByZeroException>(() => calc.Divide(2, 0));
            Assert.Throws<DivideByZeroException>(() => calc.Divide(666, 0));
        }
    }
}
