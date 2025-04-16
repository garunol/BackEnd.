using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Write("Nhập số lượng tam giác: ");
        int n = int.Parse(Console.ReadLine());

        List<TamGiac> danhSachTG = new List<TamGiac>();

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\n--- Tam giác thứ {i + 1} ---");
            TamGiac tg = new TamGiac();
            tg.Nhap();
            danhSachTG.Add(tg);
        }

        Console.WriteLine("\n--- Các tam giác thỏa mãn định lý Pytago ---");
        foreach (TamGiac tg in danhSachTG)
        {
            if (tg.LaTamGiacVuong())
            {
                tg.InCanh();
                Console.WriteLine($"Chu vi: {tg.TinhChuVi()}");
                Console.WriteLine($"Diện tích: {tg.TinhDienTich():0.##}");
                Console.WriteLine();
            }
        }

        Console.ReadKey();
    }
}
