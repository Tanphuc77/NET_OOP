namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=====================");
            int b = 2;
            ThamTri(b);
            Console.WriteLine(b);
            Console.WriteLine("=====================");
            int kq = 2;
            ThamChieu(ref kq);
            Console.WriteLine(kq);
            Console.WriteLine("=====================");
            int a;             // biến a chưa khởi tạo
            OutExample(out a); // Giờ a = 100;
            Console.WriteLine(a);
        }
        public static void ThamTri(int x)
        {
            x = x * x;
            Console.WriteLine(x);
        }
        public static void ThamChieu(ref int x)
        {
            x = x * x;
            Console.WriteLine(x);
        }
        public static void OutExample(out int x)
        {
            x = 100;
        }
    }
}

