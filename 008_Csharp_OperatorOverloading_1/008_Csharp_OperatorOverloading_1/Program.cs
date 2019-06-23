using System;
using static System.Console;

namespace _008_Csharp_OperatorOverloading_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Реализовать класс для хранения комплексного числа. Выполнить в нем перегрузку всех необходимых операторов 

            Complex z = new Complex(1, 1);
            Complex z1;
            z1 = (z + (z * z * z - 1)) / (3 * z * z);
            Console.WriteLine("z1 = {0}", z1);
        }
    }
    class Complex
    {
        double x, i;
        public Complex()
        {

        }
        public Complex(int x, int i)
        {
            this.x = x;
            this.i = i;
        }
        public double X { get { return this.x; } set { this.x = value; } }
        public double I { get { return this.i; } set { this.i = value; } }
        public override string ToString()
        {
            return $"{this.x:F2} + {this.i:F2}i";
        }
        public static Complex operator +(Complex obj1, Complex obj2)
        {
            return new Complex { X = obj1.X + obj2.X, I = obj1.I + obj2.I };
        }
        public static Complex operator -(Complex obj1, Complex obj2)
        {
            return new Complex { X = obj1.X - obj2.X, I = obj1.I - obj2.I };
        }

        public static Complex operator -(Complex obj1, double a)
        {
            return new Complex { X = obj1.X - a, I = obj1.I - a };
        }
        public static Complex operator *(Complex obj1, Complex obj2)
        {
            return new Complex { X = obj1.X * obj2.X, I = obj1.I * obj2.I };
        }

        public static Complex operator *(double a, Complex obj)
        {
            return new Complex { X = a * obj.X, I = a * obj.I };
        }
        public static Complex operator /(Complex obj1, Complex obj2)
        {
            if ((obj2.X != 0) && (obj2.I != 0))
                return new Complex { X = obj1.X / obj2.X, I = obj1.I / obj2.I };
            else
            {
                WriteLine("На ноль делить нельзя!");
                return null;
            }
        }
    }
}
