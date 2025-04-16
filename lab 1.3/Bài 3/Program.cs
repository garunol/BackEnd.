class Program
{
    static void Main()
    {
        TuyenSinh ts = new TuyenSinh();
        while (true)
        {
            Console.WriteLine("\n===== MENU =====");
            Console.WriteLine("1. Nhap thi sinh");
            Console.WriteLine("2. Hien thi thi sinh trung tuyen");
            Console.WriteLine("3. Tim theo so bao danh");
            Console.WriteLine("4. Thoat");
            Console.Write("Chon: ");
            string chon = Console.ReadLine();

            switch (chon)
            {
                case "1":
                    ts.NhapThiSinh();
                    break;
                case "2":
                    ts.HienThiTrungTuyen();
                    break;
                case "3":
                    ts.TimTheoSoBaoDanh();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Lua chon khong hop le.");
                    break;
            }
        }
    }
}
