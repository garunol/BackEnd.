using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Nhap mot so: ");
            string input = Console.ReadLine();

            if (!double.TryParse(input, out double number))
            {
                Console.WriteLine("Loi: Vui long nhap so hop le!");
                return;
            }

            if (number > 0)
                Console.WriteLine("Day la so duong.");
            else if (number < 0)
                Console.WriteLine("Day la so am.");
            else
                Console.WriteLine("Day la so 0.");
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
