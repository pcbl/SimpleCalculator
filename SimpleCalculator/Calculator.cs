using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    /// <summary>
    /// Simple Calculator, built for GFT´s Architecture Journal 2nd Edition
    /// </summary>
    public class Calculator
    {
        /// <summary>
        /// Sums up 2 numbers
        /// </summary>
        /// <param name="a">First Sumber</param>
        /// <param name="b">Second Number</param>
        /// <returns>Returns the result of the addition</returns>
        public double Sum(double a, double b)
        {
            return a + b;
        }

        /// <summary>
        /// Substracts 2 numbers
        /// </summary>
        /// <param name="a">First Sumber</param>
        /// <param name="b">Second Number</param>
        /// <returns>Returns the result of the substraction</returns>
        public double Substract(double a, double b)
        {
            return a - b;
        }
    }
}
