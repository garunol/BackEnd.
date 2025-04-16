using System;

class Program
{
    static void DemSoAmDuong(int[] arr, out int soAm, out int soDuong)
    {
        soAm = 0;
        soDuong = 0;

        foreach (int x in arr)
        {
            if (x < 0) soAm++;
            else if (x > 0) soDuong++;
        }
    }

    static void Main()
    {
        try
        {
            Console.Write("Nhap so phan tu: ");
            if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
            {
                Console.WriteLine("Loi: So luong phan tu khong hop le!");
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

            DemSoAmDuong(arr, out int am, out int duong);
            Console.WriteLine($"So luong so am: {am}, so luong so duong: {duong}");
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
