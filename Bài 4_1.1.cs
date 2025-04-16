using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Nhap mot so nguyen: ");
            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Loi: Khong duoc de trong!");
                return;
            }

            if (!int.TryParse(input, out int number))
            {
                Console.WriteLine("Loi: Phai la mot so nguyen!");
                return;
            }

            Console.WriteLine(number % 2 == 0 ? "Day la so chan." : "Day la so le.");
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
