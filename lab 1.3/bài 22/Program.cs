using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<HocSinh> danhSach = new List<HocSinh>();
        Console.Write("Nhap so luong hoc sinh: ");
        int n;
        while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
        {
            Console.Write("Vui long nhap so nguyen duong: ");
        }

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\n--- Nhap thong tin hoc sinh thu {i + 1} ---");
            HocSinh hs = new HocSinh();
            hs.Nhap();
            danhSach.Add(hs);
        }

        var danhSachSapXep = danhSach
            .OrderByDescending(hs => hs.TongDiem)
            .ThenBy(hs => hs.NamSinh)
            .ToList();

        Console.WriteLine("\n--- Danh sach hoc sinh đa sap xep ---");
        foreach (var hs in danhSachSapXep)
        {
            hs.HienThi();
        }
    }
}
