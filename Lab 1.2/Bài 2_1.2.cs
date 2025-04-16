using System;

class Program
{
    static bool LaSoNguyenTo(int n)
    {
        if (n < 2) return false;
        for (int i = 2; i <= Math.Sqrt(n); i++)
            if (n % i == 0) return false;
        return true;
    }

    static void Main()
    {
        try
        {
            Console.Write("Nhap so phan tu: ");
            if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
            {
                Console.WriteLine("Loi: So luong phan tu phai la so nguyen duong!");
                return;
            }

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap arr[{i}]: ");
                if (!int.TryParse(Console.ReadLine(), out arr[i]))
                {
                    Console.WriteLine("Loi: Chi duoc nhap so nguyen!");
                    return;
                }
            }

            Console.WriteLine("Cac phan tu la so nguyen to trong mang:");
            for (int i = 0; i < n; i++)
            {
                if (LaSoNguyenTo(arr[i]))
                {
                    Console.WriteLine($"arr[{i}] = {arr[i]}");
                }
            }
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
