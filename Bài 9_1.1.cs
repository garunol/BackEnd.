using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Nhap mot so nguyen duong: ");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int n) || n < 0)
            {
                Console.WriteLine("Loi: n phai la so nguyen >= 0!");
                return;
            }

            long gt = 1;
            for (int i = 2; i <= n; i++)
            {
                gt *= i;
            }

            Console.WriteLine($"Giai thua cua {n} la: {gt}");
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
