using System;
using System.Collections.Generic;
using System.Text;
using MainApp.Services;

namespace MainApp.UnitTest
{
    public class CalculationTestInlineData
    {
        [Theory]
        [InlineData(5,7,12)]
        [InlineData(6,8,14)]
        [InlineData(-5,-7,-12)]
        [InlineData(7,8,15)]
        [InlineData(7,-7,0)]
        [InlineData(int.MinValue,-1,int.MaxValue)]
        public void Calculator_Theory_Test_Success(int first,int second,int expected)
        {
            var calc = new Calculation();

            var result = calc.Sum(first, second);

            Assert.Equal(expected, result);
        }
    }
}
