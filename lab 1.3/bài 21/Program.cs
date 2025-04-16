using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<HocSinh> danhSach = new List<HocSinh>();
        Console.Write("Nhap so luong hoc sinh: ");
        int n;
        while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            Console.Write("Nhap so nguyen duong: ");

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\n--- Nhap thong tin hoc sinh thu {i + 1} ---");
            Console.Write("Hoc sinh la Nam? (true/false): ");
            bool gioiTinh = bool.Parse(Console.ReadLine());

            HocSinh hs;
            if (gioiTinh)
                hs = new HocSinhNam();
            else
                hs = new HocSinhNu();

            hs.Nhap();
            danhSach.Add(hs);
        }

        // 2. Hien thi hoc sinh nam co diem ky thuat >= 8
        Console.WriteLine("\n--- Hoc sinh nam co diem Ky Thuat >= 8 ---");
        foreach (var hs in danhSach)
        {
            if (hs is HocSinhNam hsNam && hsNam.KyThuat >= 8)
                hsNam.HienThi();
        }

        // 3. In hoc sinh nam truoc, nu sau
        Console.WriteLine("\n--- Danh sach hoc sinh (Nam truoc, Nu sau) ---");
        foreach (var hs in danhSach)
        {
            if (hs.LaNam)
                hs.HienThi();
        }
        foreach (var hs in danhSach)
        {
            if (!hs.LaNam)
                hs.HienThi();
        }
    }
}
