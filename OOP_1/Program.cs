namespace OOP_1
{
    class SanPham
    {
        private string masp;
        private string tensp;
        private float gia;
        private int slton;

        public SanPham()
        {
        }

        public SanPham(string masp, string tensp, float gia, int slton)
        {
            this.masp = masp;
            this.tensp = tensp;
            this.gia = gia;
            this.slton = slton;
        }

        public string Masp { get => masp; set => masp = value; }
        public string Tensp { get => tensp; set => tensp = value; }
        public float Gia { get => gia; set => gia = value; }
        public int Slton { get => slton; set => slton = value; }

        public void DisPlay()
        {
            Console.Write("\nMaSP: " + masp);
            Console.Write("\tTenSP: " + tensp);
            Console.Write("\tGia: " + gia);
            Console.Write("\tSoLuong: " + slton);
        }
    }
    class SanPhamService
    {
        private List<SanPham> listsanpham;
        private SanPham sanpham;
        private string Input;
        public SanPhamService()
        {
            listsanpham = new List<SanPham> {
            new SanPham("01", "Bot Giat Omo", 200000, 50),
            new SanPham("02", "Nuoc Rua Chen", 300000, 50),
            new SanPham("03", "Mi tom omachi", 500000, 50)
           };
        }
        // Thêm Sản Phẩm
        public void AddSanpham()
        {
            Console.Write("Nhap Vao So Luong San Pham Ma Ban Muon Them: ");
            Input = Console.ReadLine();
            for (int i = 0; i < Convert.ToInt32(Input); i++)
            {
                sanpham = new SanPham();
                Console.Write("Moi Ban Nhap Ma: ");
                sanpham.Masp = Console.ReadLine();
                Console.Write("Moi Ban Nhap Ten: ");
                sanpham.Tensp = Console.ReadLine();
                Console.Write("Moi Ban Nhap Don Gia: ");
                sanpham.Gia = float.Parse(Console.ReadLine());
                Console.Write("Moi Ban Nhap So Luong Ton: ");
                sanpham.Slton = int.Parse(Console.ReadLine());
                listsanpham.Add(sanpham);
            }
        }
        // Xoa
        public void removeSanPham()
        {
            int temp = getIndex();
            if (temp == -1)
            {
                Console.WriteLine("Khong Tim Thay");
                return;
            }
            listsanpham.RemoveAt(temp);
            Console.WriteLine("Xoa Thanh Cong");
        }
        // Sua
        public void editSanPham()
        {
            int temp = getIndex();
            if (temp == -1)
            {
                Console.WriteLine("Khong Tim Thay");
                return;
            }
            Console.WriteLine("Cac Thong Tin can Sua: ");
            Console.WriteLine("1. Sua Ten");
            Console.WriteLine("2. Sua Gia");
            Console.WriteLine("3. Sua So Luong Ton");
            Console.Write("Moi Ban Chon Chuc nang: ");
            Input = Console.ReadLine();
            switch (Input)
            {
                case "1":
                    Console.Write("Moi Ban Nhap Lai Ten: ");
                    listsanpham[temp].Tensp = Console.ReadLine();
                    break;
                case "2":
                    Console.Write("Moi Ban Nhap Lai Gia ");
                    listsanpham[temp].Gia = float.Parse(Console.ReadLine());
                    break;
                case "3":
                    Console.Write("Moi Ban Nhap Lai So Luong Ton: ");
                    listsanpham[temp].Slton = int.Parse(Console.ReadLine());
                    break;
                default:
                    Console.WriteLine("Chuc Nang Khong Ton Tai");
                    break;
            }
        }
        // Tiem Kiem
        public void findSanPham()
        {
            int temp = getIndex();
            if (temp == -1)
            {
                Console.WriteLine("Khong Tim Thay");
                return;
            }
            listsanpham[temp].DisPlay();
        }
        public void InPutSanPham()
        {
            foreach (var x in listsanpham)
            {
                x.DisPlay();
            }
        }
        public int getIndex()
        {
            Console.Write("Moi Ban Nhap Ma can Tiem: ");
            Input = Console.ReadLine();
            for (int i = 0; i < listsanpham.Count; i++)
            {
                if (listsanpham[i].Masp == Input)
                {
                    return i;
                }
            }
            return -1;
        }
    }
    class Program
    {
        static void Main()
        {
            SanPhamService SP = new SanPhamService();
            do
            {
                Console.WriteLine("\nQUAN LY SAN PHAM TAI CUA HANG");
                Console.Write("1.Tiem Kiem");
                Console.Write("\n2.Them San Pham");
                Console.Write("\n3.Xoa San Pham");
                Console.Write("\n4.Sua San Pham");
                Console.Write("\n5.In Danh Sach");
                Console.Write("\nMoi Ban Chon Chuc Nang: ");
                string chucnang = Console.ReadLine();
                switch (chucnang)
                {
                    case "1":
                        SP.findSanPham();
                        break;
                    case "2":
                        SP.AddSanpham();
                        break;
                    case "3":
                        SP.removeSanPham();
                        break;
                    case "4":
                        SP.editSanPham();
                        break;
                    case "5":
                        SP.InPutSanPham();
                        break;
                }
            } while (true);
        }
    }
}
