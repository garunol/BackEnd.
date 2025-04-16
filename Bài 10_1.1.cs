using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Nhap mot so nguyen duong >= 2: ");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int number) || number < 2)
            {
                Console.WriteLine("Loi: Vui long nhap so nguyen >= 2!");
                return;
            }

            bool isPrime = true;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            Console.WriteLine(isPrime ? "Day la so nguyen to." : "Day khong phai so nguyen to.");
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
