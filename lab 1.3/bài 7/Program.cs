using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main()
    {
        List<CBGV> danhSachCBGV = new List<CBGV>();

        while (true)
        {
            Console.WriteLine("\n====== MENU ======");
            Console.WriteLine("1. Nhap danh sach can bo giao vien");
            Console.WriteLine("2. Tim kiem can bo theo que quan");
            Console.WriteLine("3. Hien thi can bo co luong thuc linh > 5 trieu");
            Console.WriteLine("4. Thoat");
            Console.Write("Chon chuc nang: ");
            int chon = int.Parse(Console.ReadLine());

            switch (chon)
            {
                case 1:
                    Console.Write("Nhap so luong can bo giao vien: ");
                    int n = int.Parse(Console.ReadLine());

                    for (int i = 0; i < n; i++)
                    {
                        Console.WriteLine($"\nNhap can bo thu {i + 1}:");
                        CBGV cb = new CBGV();
                        cb.Nhap();
                        danhSachCBGV.Add(cb);
                    }
                    break;

                case 2:
                    Console.Write("Nhap que quan can tim: ");
                    string que = Console.ReadLine().ToLower();

                    var ketQua = danhSachCBGV.Where(cb =>
                        cb.ThongTinCaNhan.QueQuan.ToLower().Contains(que));

                    Console.WriteLine("\nDanh sach can bo theo que quan:");
                    foreach (var cb in ketQua)
                    {
                        cb.HienThi();
                    }
                    break;

                case 3:
                    Console.WriteLine("\nDanh sach can bo co luong thuc linh > 5 trieu:");
                    foreach (var cb in danhSachCBGV)
                    {
                        if (cb.LuongThucLinh > 5000000)
                            cb.HienThi();
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
