using System;

public class Program
{
    public static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("Nhap so phuc A:");
        SoPhuc A = new SoPhuc();
        A.Nhap();

        Console.WriteLine("Nhap so phuc B:");
        SoPhuc B = new SoPhuc();
        B.Nhap();

        while (true)
        {
            Console.WriteLine("\n===== MENU =====");
            Console.WriteLine("a. Tinh tong hai so phuc");
            Console.WriteLine("b. Tinh hieu hai so phuc");
            Console.WriteLine("c. Tinh tich hai so phuc");
            Console.WriteLine("d. Tinh thuong hai so phuc");
            Console.WriteLine("e. Thoat");
            Console.Write("Chon chuc nang: ");
            string chon = Console.ReadLine();

            try
            {
                switch (chon.ToLower())
                {
                    case "a":
                        Console.Write("Tong A + B = ");
                        A.Cong(B).HienThi();
                        break;

                    case "b":
                        Console.Write("Hieu A - B = ");
                        A.Tru(B).HienThi();
                        break;

                    case "c":
                        Console.Write("Tich A * B = ");
                        A.Nhan(B).HienThi();
                        break;

                    case "d":
                        Console.Write("Thuong A / B = ");
                        A.Chia(B).HienThi();
                        break;

                    case "e":
                        Console.WriteLine("Da thoat chuong trinh.");
                        return;

                    default:
                        Console.WriteLine("Lua chon khong hop le. Vui long chon lai.");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Loi: " + ex.Message);
            }
        }
    }
}
