using System;
using System.Collections.Generic;
using System.Text;

namespace D_OOP
{
    public abstract class Shapes
    {
        public Shapes()
        {
            Console.WriteLine("Shape created");
        }
        // Это КОНТРАКТ!
        public abstract void Draw();

        public abstract double Area();

        public abstract double Perimetr();
    }

    public class Triangle : Shapes
    {
        private readonly double a;
        private readonly double b;
        private readonly double c;

        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            Console.WriteLine("Triangle created");
        }
        public override double Area()
        {
            double s = (a + b + c) / 2;
            return Math.Sqrt(s*(s - a)*(s - b)*(s - c));
        }

        public override void Draw()
        {
            Console.WriteLine("Drowing Triangle");
        }

        public override double Perimetr()
        {
            return a + b + c;
        }
    }
    public class Rectangle : Shapes
    {
        private readonly double wight;
        private readonly double height;

        public Rectangle(double wight, double height)
        {
            this.wight = wight;
            this.height = height;

            Console.WriteLine("Rectangle created");
        }

        public override double Area()
        {
            return wight * height;
        }

        public override void Draw()
        {
            Console.WriteLine("Drowing rectangle");
        }

        public override double Perimetr()
        {
            return 2 * (height + wight);
        }
    }
}
