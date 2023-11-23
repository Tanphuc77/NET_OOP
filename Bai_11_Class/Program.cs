namespace Bai_11_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            VuKhi vuKhi = new VuKhi();
            vuKhi.name = "Súng AK";
            vuKhi.SetDoSatThuong(10);
            vuKhi.TanCong();

            Console.WriteLine("============================");
            VuKhi vuKhi1 = new VuKhi("Súng Máy", 20);
            vuKhi1.TanCong();
        }
    }
}


