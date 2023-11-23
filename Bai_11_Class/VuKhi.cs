namespace Bai_11_Class
{
    class VuKhi
    {
        public string name = "Tên Vũ Khí";
        int dosatthuong = 0;
        public int satthuong
        {
            set
            {
                dosatthuong = value;
            }
            get
            {
                return dosatthuong;
            }
        }
        public VuKhi()
        {

        }
        public VuKhi(string name, int dosatthuong)
        {
            this.name = name;
            SetDoSatThuong(dosatthuong);
        }
        public void SetDoSatThuong(int mucdo)
        {
            this.dosatthuong = mucdo;
        }
        public void TanCong()
        {
            Console.Write(name + ": \t");
            for (int i = 0; i <= dosatthuong; i++)
            {
                Console.Write(" * ");
            }
            Console.WriteLine();
        }
    }
}