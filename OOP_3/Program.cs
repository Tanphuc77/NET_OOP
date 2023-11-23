using System;
namespace OOP_3
{
    class Nguoi
    {
        private string sochungminh { get; set; }
        private string hoten { get; set; }
        private double namsinh { get; set; }
        public virtual void Input()
        {
            Console.Write("Nhap so chung minh: ");
            sochungminh = Console.ReadLine();
            Console.Write("Nhap ho ten: ");
            hoten = Console.ReadLine();
            Console.Write("Nhap nam sinh: ");
            namsinh = double.Parse(Console.ReadLine());
        }
        public virtual void Output()
        {
            Console.Write("\nSo chung minh: " + sochungminh);
            Console.Write("\tHo ten: " + hoten);
            Console.Write("\tNam sinh: " + namsinh);
        }
    }
    class Nhanvien : Nguoi
    {
        private double hesoluong;
        private double phucap;
        private double tienluong;
        public double Tinhluong()
        {
            return tienluong = hesoluong * 1390000 + phucap;
        }
        public override void Input()
        {
            base.Input();
            Console.Write("Nhap vao he so luong: ");
            hesoluong = double.Parse(Console.ReadLine());
            Console.Write("Nhap vao phu cap: ");
            phucap = double.Parse(Console.ReadLine());
            Tinhluong();
        }
        public override void Output()
        {
            base.Output();
            Console.Write("\tHe so luong: " + hesoluong);
            Console.Write("\tPhu cap: " + phucap);
            Console.Write("\tTien luong: " + Tinhluong());
        }
    }
    class TESTER
    {
        static void Main()
        {
            Nhanvien nv1 = new Nhanvien();
            nv1.Input();
            nv1.Output();
            Console.ReadKey();
        }
    }
}