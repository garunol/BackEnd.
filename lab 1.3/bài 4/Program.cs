
class Program
{
    static void Main(string[] args)
    {
        KhuPho khuPho = new KhuPho();

        while (true)
        {
            Console.WriteLine("\n===== MENU =====");
            Console.WriteLine("1. Nhap thong tin ho dan");
            Console.WriteLine("2. Hien thi tat ca ho dan");
            Console.WriteLine("3. Tim kiem theo ho ten");
            Console.WriteLine("4. Tim kiem theo so nha");
            Console.WriteLine("5. Thoat");
            Console.Write("Chon chuc nang: ");
            string chon = Console.ReadLine();

            switch (chon)
            {
                case "1":
                    khuPho.NhapDanhSach();
                    break;
                case "2":
                    khuPho.HienThiTatCa();
                    break;
                case "3":
                    Console.Write("Nhap ho ten can tim: ");
                    string ten = Console.ReadLine();
                    khuPho.TimKiemTheoTen(ten);
                    break;
                case "4":
                    Console.Write("Nhap so nha can tim: ");
                    string soNha = Console.ReadLine();
                    khuPho.TimKiemTheoSoNha(soNha);
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Lua chon khong hop le. Vui long thu lai.");
                    break;
            }
        }
    }
}
