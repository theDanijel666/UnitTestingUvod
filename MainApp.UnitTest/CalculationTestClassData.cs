using MainApp.Services;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MainApp.UnitTest
{
    public class CalculationTestClassData
    {
        [Theory]
        [ClassData(typeof(CalculatorTestData))]
        public void Calculator_Theory_Test_Success(int first, int second, int expected)
        {
            var calc = new Calculation();

            var result = calc.Sum(first, second);

            Assert.Equal(expected, result);
        }
    }

    public class CalculatorTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { 5, 7, 12 };
            yield return new object[] { -5, 7, 2 };
            yield return new object[] { 15, 34, 49 };
            yield return new object[] { -6,6,0 };
            yield return new object[] { int.MaxValue, 1, int.MinValue };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

