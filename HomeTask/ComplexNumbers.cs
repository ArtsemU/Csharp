using System;
using System.Collections.Generic;
using System.Text;

namespace F_HomeTask
{
    class ComplexNumbers
    {
        public string sign = "";
        public double RealNum { get; private set; }
        public double ImageNum { get; private set; }

        public ComplexNumbers(double real, double image)
        {
            RealNum = real;
            ImageNum = image;
            sign = ImageNum >= 0 ?  "+" : "";
            Console.WriteLine($"Number is {RealNum} {sign} {ImageNum}j");
        }
        private ComplexNumbers()
        {

        }
        public ComplexNumbers plusNumber(ComplexNumbers cn) 
        {
            var complex = new ComplexNumbers();
            complex.RealNum = RealNum + cn.RealNum;
            complex.ImageNum = ImageNum + cn.ImageNum;

            return complex;
        }


    }
}
