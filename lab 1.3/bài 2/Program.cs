using System;

class Program
{
    static void Main(string[] args)
    {
        QuanLy ql = new QuanLy();

        while (true)
        {
            Console.WriteLine("\n======= MENU =======");
            Console.WriteLine("1. Nhap danh sach");
            Console.WriteLine("2. Hien thi danh sach");
            Console.WriteLine("3. Tim kiem theo ho ten");
            Console.WriteLine("4. Thoat");
            Console.Write("Chon chuc nang: ");
            int chon = int.Parse(Console.ReadLine());

            switch (chon)
            {
                case 1: ql.NhapDanhSach(); break;
                case 2: ql.HienThiDanhSach(); break;
                case 3: ql.TimKiemTheoHoTen(); break;
                case 4: return;
                default: Console.WriteLine("Lua chon khong hop le."); break;
            }
        }
    }
}

