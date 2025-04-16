using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Hinh> danhSachHinh = new List<Hinh>();
        Console.Write("Nhap so luong hinh: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Nhap thong tin cho hinh thu {i + 1}");
            Console.WriteLine("1. Hinh tron");
            Console.WriteLine("2. Hinh vuong");
            Console.WriteLine("3. Hinh chu nhat");
            Console.WriteLine("4. Hinh tam giac");
            Console.Write("Chon loai hinh (1-4): ");
            int loai = int.Parse(Console.ReadLine());

            switch (loai)
            {
                case 1:
                    Console.Write("Nhap ban kinh: ");
                    double r = double.Parse(Console.ReadLine());
                    danhSachHinh.Add(new HinhTron(r));
                    break;

                case 2:
                    Console.Write("Nhap canh: ");
                    double canh = double.Parse(Console.ReadLine());
                    danhSachHinh.Add(new HinhVuong(canh));
                    break;

                case 3:
                    Console.Write("Nhap chieu dai: ");
                    double dai = double.Parse(Console.ReadLine());
                    Console.Write("Nhap chieu rong: ");
                    double rong = double.Parse(Console.ReadLine());
                    danhSachHinh.Add(new HinhChuNhat(dai, rong));
                    break;

                case 4:
                    Console.Write("Nhap canh a: ");
                    double a = double.Parse(Console.ReadLine());
                    Console.Write("Nhap canh b: ");
                    double b = double.Parse(Console.ReadLine());
                    Console.Write("Nhap canh c: ");
                    double c = double.Parse(Console.ReadLine());
                    if (a + b > c && a + c > b && b + c > a)
                    {
                        danhSachHinh.Add(new HinhTamGiac(a, b, c));
                    }
                    else
                    {
                        Console.WriteLine("Khong phai tam giac hop le.");
                        i--; // yeu cau nhap lai
                    }
                    break;

                default:
                    Console.WriteLine("Lua chon khong hop le. Vui long nhap lai.");
                    i--; // nhap lai
                    break;
            }
        }

        double tongChuVi = 0;
        double tongDienTich = 0;

        Console.WriteLine("\n=== Ket qua ===");
        for (int i = 0; i < danhSachHinh.Count; i++)
        {
            Hinh h = danhSachHinh[i];
            Console.WriteLine($"Hinh {i + 1}: Chu vi = {h.TinhChuVi()}, Dien tich = {h.TinhDienTich()}");
            tongChuVi += h.TinhChuVi();
            tongDienTich += h.TinhDienTich();
        }

        Console.WriteLine($"\nTong chu vi tat ca hinh: {tongChuVi}");
        Console.WriteLine($"Tong dien tich tat ca hinh: {tongDienTich}");
    }
}
