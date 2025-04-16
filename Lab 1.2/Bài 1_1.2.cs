using System;
using System.Linq;

class Program
{
    static int TinhTongChan(int[] arr)
    {
        int tong = 0;
        foreach (int x in arr)
        {
            if (x % 2 == 0)
                tong += x;
        }
        return tong;
    }

    static void Main()
    {
        try
        {
            Console.Write("Nhap so phan tu cua mang: ");
            string input = Console.ReadLine();
            if (!int.TryParse(input, out int n) || n <= 0)
            {
                Console.WriteLine("Loi: n phai la so nguyen duong!");
                return;
            }

            int[] mang = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap phan tu thu {i + 1}: ");
                string so = Console.ReadLine();
                if (!int.TryParse(so, out mang[i]))
                {
                    Console.WriteLine("Loi: Vui long nhap so nguyen hop le!");
                    return;
                }
            }

            Console.WriteLine($"Tong cac so chan trong mang: {TinhTongChan(mang)}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Loi he thong: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Ket thuc chuong trinh.");
        }
    }
}
