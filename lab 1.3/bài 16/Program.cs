using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Write("Nhập số tam giác: ");
        int n = int.Parse(Console.ReadLine());

        List<TamGiac> danhSach = new List<TamGiac>();
        double tongChuVi = 0, tongDienTich = 0;

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\n--- Nhập tam giác thứ {i + 1} ---");
            TamGiac tg = new TamGiac();
            tg.Nhap();
            danhSach.Add(tg);

            double cv = tg.TinhChuVi();
            double dt = tg.TinhDienTich();

            Console.WriteLine("Chu vi: " + cv);
            Console.WriteLine("Diện tích: " + dt.ToString("0.##"));

            tongChuVi += cv;
            tongDienTich += dt;
        }

        Console.WriteLine($"\n--- Kết quả tổng ---");
        Console.WriteLine("Tổng chu vi: " + tongChuVi.ToString("0.##"));
        Console.WriteLine("Tổng diện tích: " + tongDienTich.ToString("0.##"));

        Console.ReadKey();
    }
}
