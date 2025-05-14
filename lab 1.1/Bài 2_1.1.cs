using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Nhap chieu dai: ");
            string lengthInput = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(lengthInput))
            {
                Console.WriteLine("Loi: Khong duoc de trong chieu dai!");
                return;
            }

            if (!double.TryParse(lengthInput, out double length) || length <= 0)
            {
                Console.WriteLine("Loi: Chieu dai phai la so thuc duong!");
                return;
            }

            Console.Write("Nhap chieu rong: ");
            string widthInput = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(widthInput))
            {
                Console.WriteLine("Loi: Khong duoc de trong chieu rong!");
                return;
            }

            if (!double.TryParse(widthInput, out double width) || width <= 0)
            {
                Console.WriteLine("Loi: Chieu rong phai la so thuc duong!");
                return;
            }

            double area = length * width;
            Console.WriteLine($"Dien tich hinh chu nhat la: {area}");
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
