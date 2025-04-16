using System;

class Program
{
    static void Main(string[] args)
    {
        QLCB qlcb = new QLCB();

        while (true)
        {
            Console.WriteLine("\n======= MENU =======");
            Console.WriteLine("1. Nhap thong tin can bo");
            Console.WriteLine("2. Tim kiem theo ho ten");
            Console.WriteLine("3. Hien thi danh sach can bo");
            Console.WriteLine("4. Thoat");
            Console.Write("Chon chuc nang: ");
            int chon = int.Parse(Console.ReadLine());

            switch (chon)
            {
                case 1: qlcb.NhapThongTin(); break;
                case 2: qlcb.TimKiemTheoHoTen(); break;
                case 3: qlcb.HienThiDanhSach(); break;
                case 4: return;
                default: Console.WriteLine("Lua chon khong hop le."); break;
            }
        }
    }
}

