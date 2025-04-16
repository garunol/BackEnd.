using System;

class Program
{
    static void HoanVi(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    static void Main()
    {
        try
        {
            Console.Write("Nhap so a: ");
            if (!int.TryParse(Console.ReadLine(), out int a))
            {
                Console.WriteLine("Loi: a phai la so nguyen!");
                return;
            }

            Console.Write("Nhap so b: ");
            if (!int.TryParse(Console.ReadLine(), out int b))
            {
                Console.WriteLine("Loi: b phai la so nguyen!");
                return;
            }

            HoanVi(ref a, ref b);
            Console.WriteLine($"Sau khi hoan vi: a = {a}, b = {b}");
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
