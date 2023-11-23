using System;
namespace test3
{
    class Complex
    {
        private double a;
        public double Phanthuc
        {
            get { return a; }
            set { a = value; }
        }
        private double b;
        public double Phanao
        {
            get { return b; }
            set { b = value; }
        }

        public void ToString()
        {
            Console.WriteLine("{0} {1}!", a, b);
        }
        public double GetMagnitude()
        {
            return (float)Math.Sqrt(a * a + b * b);
        }
        public void Sum(Complex complex1)
        {
            Console.WriteLine($"({this.a + complex1.a}, {this.b + complex1.b})");
        }
    }
    class Tester
    {
        static void Main(string[] args)
        {
            Complex a = new Complex();
            a.Phanthuc = 1;
            a.Phanao = -2;
            a.ToString();
            Console.Write("Do lon cua so phuc: ");
            Console.WriteLine(a.GetMagnitude());
            Complex b = new Complex();
            b.Phanthuc = 2;
            b.Phanao = 2;
            Console.WriteLine("Tong cua 2 so phuc: ");
            a.Sum(b);
            Console.ReadKey();
        }
    }
}
