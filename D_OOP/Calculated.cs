using System;
using System.Collections.Generic;
using System.Text;

namespace D_OOP
{
    public class Calculator
    {

        public bool TryDivide(double divisible, double divisor, out double result) {
            result = 0;
            if (divisor == 0) {
                return false;
            }
            result = divisible / divisor;
            return true;
        }
        public double Average(int[] numbers) {
            int sum = 0;
            foreach (int n in numbers) {
                sum += n;
            }
            return (double)sum / numbers.Length;
        }
        public double Average2(params int[] numbers)
        {
            int sum = 0;
            foreach (int n in numbers)
            {
                sum += n;
            }
            return (double)sum / numbers.Length;
        }
        public double CalcTriangleSquare(double a, double b, double c) {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
        public double CalcTriangleSquare(double b, double h) {
            return 0.5 * b * h;
        }
        public double CalcTriangleSquare(double a, double b, int c) {

            return 0.5 * a * b * Math.Sin(c);
           }
    }
}
