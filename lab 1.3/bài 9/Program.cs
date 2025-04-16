using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        List<BienLai> danhSachBienLai = new List<BienLai>();

        while (true)
        {
            Console.WriteLine("\n===== MENU =====");
            Console.WriteLine("1. Nhap danh sach bien lai");
            Console.WriteLine("2. Hien thi thong tin bien lai");
            Console.WriteLine("3. Thoat");
            Console.Write("Chon chuc nang: ");
            int chon = int.Parse(Console.ReadLine());

            switch (chon)
            {
                case 1:
                    Console.Write("Nhap so luong bien lai: ");
                    int n = int.Parse(Console.ReadLine());
                    for (int i = 0; i < n; i++)
                    {
                        Console.WriteLine($"\nNhap bien lai thu {i + 1}:");
                        BienLai bl = new BienLai();
                        bl.Nhap();
                        danhSachBienLai.Add(bl);
                    }
                    break;

                case 2:
                    Console.WriteLine("\n==== THONG TIN CAC BIEN LAI ====");
                    foreach (var bl in danhSachBienLai)
                    {
                        bl.HienThi();
                        Console.WriteLine("--------------------------------");
                    }
                    break;

                case 3:
                    return;

                default:
                    Console.WriteLine("Lua chon khong hop le.");
                    break;
            }
        }
    }
}
