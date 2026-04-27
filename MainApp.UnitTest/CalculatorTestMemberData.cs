using MainApp.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace MainApp.UnitTest
{
    public class CalculatorTestMemberData
    {
        [Theory]
        [MemberData(nameof(CalculatorData))]
        public void Calculator_Theory_Test_Success(int first, int second, int expected)
        {
            var calc = new Calculation();

            var result = calc.Sum(first, second);

            Assert.Equal(expected, result);
        }

        public static IEnumerable<object[]> CalculatorData
        {
            get
            {
                return new List<object[]>
                {
                    new object[] {5,7,12},
                    new object[] {-5,-7,-12},
                    new object[] { 5,-7,-2},
                    new object[] { -13,13,0 },
                    new object[] { int.MaxValue,1,int.MinValue }
                };
            }
        }
    }
}
