using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculatorTests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void When_Sum_1_and_2_expect_3()
        {
            const double a = 1;
            const double b = 2;
            const double expected = 3;
            var calc = new Calculator();
            var result = calc.Sum(a, b);
            Assert.AreEqual(expected,result);
        }

        [TestMethod()]
        public void When_Substract_5_and_2_expect_3()
        {
            const double a = 5;
            const double b = 2;
            const double expected = 3;
            var calc = new Calculator();
            var result = calc.Substract(a, b);
            Assert.AreEqual(expected, result);
        }
    }
}