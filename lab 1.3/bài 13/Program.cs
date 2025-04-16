class Program
{
    static void Main()
    {
        QLPTGT ql = new QLPTGT();
        int chon;

        do
        {
            Console.WriteLine("1. Dang ky phuong tien");
            Console.WriteLine("2. Tim theo mau hoac nam san xuat");
            Console.WriteLine("3. Hien thi tat ca");
            Console.WriteLine("0. Thoat");
            Console.Write("Chon chuc nang: ");
            chon = int.Parse(Console.ReadLine());

            switch (chon)
            {
                case 1: ql.NhapPhuongTien(); break;
                case 2: ql.TimTheoMauHoacNam(); break;
                case 3: ql.HienThiTatCa(); break;
                case 0: Console.WriteLine("Tam biet!"); break;
                default: Console.WriteLine("Lua chon khong hop le!"); break;
            }

            Console.WriteLine();
        } while (chon != 0);
    }
}
