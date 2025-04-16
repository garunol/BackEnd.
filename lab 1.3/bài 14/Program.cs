class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        PhanSo A = new PhanSo();
        PhanSo B = new PhanSo();

        Console.WriteLine("Nhập phân số A:");
        A.Nhap();
        Console.WriteLine("Nhập phân số B:");
        B.Nhap();

        A.RutGon();
        B.RutGon();

        Console.Write("Phân số A sau khi rút gọn: ");
        A.HienThi();
        Console.Write("Phân số B sau khi rút gọn: ");
        B.HienThi();

        Console.WriteLine("\n--- MENU ---");
        Console.WriteLine("1. Cộng A + B");
        Console.WriteLine("2. Trừ A - B");
        Console.WriteLine("3. Nhân A * B");
        Console.WriteLine("4. Chia A / B");
        Console.Write("Chọn thao tác: ");
        int chon = int.Parse(Console.ReadLine());

        PhanSo ketQua = null;

        switch (chon)
        {
            case 1:
                ketQua = A.Cong(B);
                Console.Write("Tổng A + B = ");
                break;
            case 2:
                ketQua = A.Tru(B);
                Console.Write("Hiệu A - B = ");
                break;
            case 3:
                ketQua = A.Nhan(B);
                Console.Write("Tích A * B = ");
                break;
            case 4:
                ketQua = A.Chia(B);
                Console.Write("Thương A / B = ");
                break;
            default:
                Console.WriteLine("Lựa chọn không hợp lệ.");
                return;
        }

        ketQua.RutGon();
        ketQua.HienThi();

        Console.ReadKey();
    }
}
