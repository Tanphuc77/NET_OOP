using System;
namespace Baitap1_4_tren_lop
{
    class Cercle
    {
        private double rauyon;

        public Cercle(double rauyon)
        {
            this.rauyon = rauyon;
        }
        public double GetArea()
        {
            return rauyon * rauyon * 3.14;
        }
        public double GetPerimeter()
        {
            return 2 * rauyon * 3.14;
        }
    }
    class Bai_1
    {
        static void Main(string[] args)
        {
            Cercle c = new Cercle(3);
            Console.WriteLine("Dien tich hinh tron: " + c.GetArea());
            Console.WriteLine("Chu vi hinh tron: " + c.GetPerimeter());
            Console.ReadKey();
        }
    }
}