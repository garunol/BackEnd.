using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Nhap mot nam: ");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int year) || year <= 0)
            {
                Console.WriteLine("Loi: Nam phai la so nguyen duong!");
                return;
            }

            bool isLeap = (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
            Console.WriteLine(isLeap ? "Day la nam nhuan." : "Day khong phai nam nhuan.");
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
