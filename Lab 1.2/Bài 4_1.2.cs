using System;

class Program
{
    static int TimSoLonThuHai(int[] arr)
    {
        int max1 = int.MinValue, max2 = int.MinValue;

        foreach (int x in arr)
        {
            if (x > max1)
            {
                max2 = max1;
                max1 = x;
            }
            else if (x > max2 && x < max1)
            {
                max2 = x;
            }
        }

        if (max2 == int.MinValue)
            throw new Exception("Mang khong co so lon thu hai hop le!");

        return max2;
    }

    static void Main()
    {
        try
        {
            Console.Write("Nhap so phan tu: ");
            if (!int.TryParse(Console.ReadLine(), out int n) || n < 2)
            {
                Console.WriteLine("Loi: Can it nhat 2 phan tu de tim so lon thu hai!");
                return;
            }

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap arr[{i}]: ");
                if (!int.TryParse(Console.ReadLine(), out arr[i]))
                {
                    Console.WriteLine("Loi: Chi duoc nhap so nguyen!");
                    return;
                }
            }

            int max2 = TimSoLonThuHai(arr);
            Console.WriteLine($"So lon thu hai la: {max2}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Loi: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Ket thuc chuong trinh.");

        }
    }
}
