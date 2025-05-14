using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Nhap nhiet do (C): ");
            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Loi: Khong duoc de trong!");
                return;
            }

            if (!double.TryParse(input, out double celsius))
            {
                Console.WriteLine("Loi: Nhiet do phai la mot so!");
                return;
            }

            double fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine($"Nhiet do tuong ung (F): {fahrenheit}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Loi he thong: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("ket thuc chuong trinh.");
        }
    }
}
