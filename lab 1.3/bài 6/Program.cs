using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main()
    {
        List<HSHocSinh> danhSachHS = new List<HSHocSinh>();

        while (true)
        {
            Console.WriteLine("\n====== MENU ======");
            Console.WriteLine("1. Nhap danh sach hoc sinh");
            Console.WriteLine("2. Hien thi hoc sinh nu va sinh nam 1985");
            Console.WriteLine("3. Tim hoc sinh theo que quan");
            Console.WriteLine("4. Thoat");
            Console.Write("Chon chuc nang: ");
            int chon = int.Parse(Console.ReadLine());

            switch (chon)
            {
                case 1:
                    Console.Write("Nhap so luong hoc sinh: ");
                    int n = int.Parse(Console.ReadLine());

                    for (int i = 0; i < n; i++)
                    {
                        Console.WriteLine($"\nNhap hoc sinh thu {i + 1}:");
                        HSHocSinh hs = new HSHocSinh();
                        hs.Nhap();
                        danhSachHS.Add(hs);
                    }
                    break;

                case 2:
                    Console.WriteLine("\nDanh sach hoc sinh nu sinh nam 1985:");
                    var ketQua = danhSachHS.Where(hs =>
                        hs.ThongTinCaNhan.GioiTinh.ToLower() == "nu" &&
                        hs.ThongTinCaNhan.NamSinh == 1985);

                    foreach (var hs in ketQua)
                    {
                        hs.HienThi();
                    }
                    break;

                case 3:
                    Console.Write("Nhap que quan can tim: ");
                    string que = Console.ReadLine().ToLower();

                    var ketQuaTim = danhSachHS.Where(hs =>
                        hs.ThongTinCaNhan.QueQuan.ToLower().Contains(que));

                    Console.WriteLine("\nDanh sach hoc sinh theo que quan:");
                    foreach (var hs in ketQuaTim)
                    {
                        hs.HienThi();
                    }
                    break;

                case 4:
                    return;

                default:
                    Console.WriteLine("Lua chon khong hop le.");
                    break;
            }
        }
    }
}
