using System;

class Program
{
    static void SapXepTangDan(double[] arr)
    {
        Array.Sort(arr);
    }

    static void Main()
    {
        try
        {
            Console.Write("Nhap so luong phan tu: ");
            if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
            {
                Console.WriteLine("Loi: So luong phan tu phai la so nguyen duong!");
                return;
            }

            double[] arr = new double[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap arr[{i}]: ");
                if (!double.TryParse(Console.ReadLine(), out arr[i]))
                {
                    Console.WriteLine("Loi: Vui long nhap so thuc!");
                    return;
                }
            }

            SapXepTangDan(arr);

            Console.WriteLine("Mang sau khi sap xep tang dan:");
            foreach (double x in arr)
            {
                Console.Write(x + " ");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Loi: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("\nKet thuc chuong trinh.");
        }
    }
}
