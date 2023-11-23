namespace Bai_11_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            VuKhi vuKhi = new VuKhi();
            vuKhi.name = "Súng AK";
            vuKhi.SetDoSatThuong(10);
            Console.WriteLine(vuKhi.satthuong);
            vuKhi.TanCong();

            Console.WriteLine("============================");
            VuKhi vuKhi1 = new VuKhi("Súng Máy", 20);
            Console.WriteLine(vuKhi1.satthuong);
            vuKhi1.TanCong();
        }
    }
}


