using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Bang cuu chuong tu 1 den 10:");

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"\nBang nhan {i}:");
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{i} x {j} = {i * j}");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Loi khi in bang: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Ket thuc chuong trinh.");
        }
    }
}
