using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Write("Nhập số lượng hình tròn: ");
        int n = int.Parse(Console.ReadLine());

        List<HinhTron> danhSach = new List<HinhTron>();
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\n--- Nhập hình tròn thứ {i + 1} ---");
            HinhTron ht = new HinhTron();
            ht.Nhap();
            danhSach.Add(ht);
        }

        // Tìm hình tròn giao với nhiều hình tròn khác nhất
        int maxGiao = 0;
        int viTri = 0;

        for (int i = 0; i < n; i++)
        {
            int dem = 0;
            for (int j = 0; j < n; j++)
            {
                if (i != j && danhSach[i].GiaoNhau(danhSach[j]))
                {
                    dem++;
                }
            }
            if (dem > maxGiao)
            {
                maxGiao = dem;
                viTri = i;
            }
        }

        Console.WriteLine($"\n--- Hình tròn giao với nhiều hình khác nhất ({maxGiao} hình): ---");
        danhSach[viTri].HienThi();
        Console.WriteLine($"Chu vi: {danhSach[viTri].TinhChuVi():0.##}");
        Console.WriteLine($"Diện tích: {danhSach[viTri].TinhDienTich():0.##}");

        Console.ReadKey();
    }
}
