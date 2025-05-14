using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Nhap so thu nhat: ");
            string input1 = Console.ReadLine();

            if (!double.TryParse(input1, out double num1))
            {
                Console.WriteLine("Loi: So thu nhat phai la mot so!");
                return;
            }

            Console.Write("Nhap so thu hai: ");
            string input2 = Console.ReadLine();

            if (!double.TryParse(input2, out double num2))
            {
                Console.WriteLine("Loi: So thu hai phai la mot so!");
                return;
            }

            Console.WriteLine($"Tong: {num1 + num2}");
            Console.WriteLine($"Tich: {num1 * num2}");
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
