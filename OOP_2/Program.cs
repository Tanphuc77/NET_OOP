using System;
namespace OOP_2
{
    class Thisinh
    {
        private string masinhvien;
        private string hoten;
        private double namsinh;
        private double diemchuyennganh;
        private double diemngoaingu;
        private double ketqua;
        public void Input()
        {
            Console.Write("\nNhap ma sinh vien: ");
            masinhvien = Console.ReadLine();
            Console.Write("Nhap ho ten sinh vien: ");
            hoten = Console.ReadLine();
            Console.Write("Nhap nam sinh sinh vien: ");
            namsinh = double.Parse(Console.ReadLine());
            Console.Write("Nhap diem chuyen nganh: ");
            diemchuyennganh = double.Parse(Console.ReadLine());
            Console.Write("Nhap diem ngoai ngu: ");
            diemngoaingu = double.Parse(Console.ReadLine());
            Console.WriteLine("====================================");
        }
        public double Ketqua()
        {
            return ketqua = (diemchuyennganh + diemngoaingu) / 2;
        }
        public void Xetdiem()
        {
            if ((diemchuyennganh >= 8) && (diemngoaingu >= 8))
            {
                Console.Write("\tTrung tuyen");
            }
            else if ((diemchuyennganh < 8) && (diemngoaingu < 8))
            {
                Console.Write("\tKhong dat");
            }
        }
        public void Output()
        {
            Console.Write("\nMa sinh vien: " + masinhvien);
            Console.Write("\tTen sinh vien: " + hoten);
            Console.Write("\tNam sinh: " + namsinh);
            Console.Write("\tDiem chuyem nganh: " + diemchuyennganh);
            Console.Write("\tDiem ngoai ngu: " + diemngoaingu);
            Console.Write("\tKet qua: " + ketqua);
            Xetdiem();

        }
    }
    internal class Tester
    {
        static int size;
        static void Main(string[] args)
        {
            Thisinh[] arrthisinh;
            do
            {
                Console.Write("Moi ban nhap so luong sinh vien: ");
                size = int.Parse(Console.ReadLine());
                if (size < 0)
                {
                    Console.WriteLine("Nhap so luong phai lon hon 0 vui long nhap lai ");
                }
            } while (size < 0);
            arrthisinh = new Thisinh[size];
            for (int i = 0; i < size; i++)
            {
                arrthisinh[i] = new Thisinh();
                arrthisinh[i].Input();
                arrthisinh[i].Ketqua();

            }
            Console.WriteLine("\nDanh sach sinh vien sau khi nhap");
            // in
            foreach (var u in arrthisinh)
            {
                u.Output();
            }
            Console.ReadKey();
        }
    }
}