class Program
{
    static void Main(string[] args)
    {
        KhachSan ks = new KhachSan();
        while (true)
        {
            Console.WriteLine("\n----- MENU -----");
            Console.WriteLine("1. Nhap danh sach khach tro");
            Console.WriteLine("2. Hien thi thong tin tat ca khach tro");
            Console.WriteLine("3. Tim kiem khach theo ten");
            Console.WriteLine("4. Tinh tien cho khach khi tra phong");
            Console.WriteLine("5. Thoat");
            Console.Write("Chon chuc nang: ");
            int chon = int.Parse(Console.ReadLine());

            switch (chon)
            {
                case 1:
                    ks.NhapDanhSach();
                    break;
                case 2:
                    ks.HienThiTatCa();
                    break;
                case 3:
                    Console.Write("Nhap ten can tim: ");
                    string ten = Console.ReadLine();
                    ks.TimKiemTheoTen(ten);
                    break;
                case 4:
                    ks.TinhTienKhachHang();
                    break;
                case 5:
                    return;
                default:
                    Console.WriteLine("Lua chon khong hop le.");
                    break;
            }

        }
    }
}
