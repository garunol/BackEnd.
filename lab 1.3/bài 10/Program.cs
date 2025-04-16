using System;

public class Program
{
    public static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Nhap noi dung van ban: ");
        string input = Console.ReadLine();

        VanBan vb = new VanBan(input);

        while (true)
        {
            Console.WriteLine("\n===== MENU =====");
            Console.WriteLine("1. Dem so tu trong xau");
            Console.WriteLine("2. Dem so ky tu 'H' (khong phan biet hoa thuong)");
            Console.WriteLine("3. Chuan hoa xau");
            Console.WriteLine("4. Hien thi noi dung van ban");
            Console.WriteLine("5. Thoat");
            Console.Write("Chon chuc nang: ");
            string chon = Console.ReadLine();

            switch (chon)
            {
                case "1":
                    Console.WriteLine($"So tu trong van ban: {vb.DemSoTu()}");
                    break;

                case "2":
                    Console.WriteLine($"So ky tu 'H' hoac 'h': {vb.DemSoKyTuH()}");
                    break;

                case "3":
                    vb.ChuanHoaChuoi();
                    Console.WriteLine("Xau sau khi chuan hoa:");
                    vb.HienThi();
                    break;

                case "4":
                    vb.HienThi();
                    break;

                case "5":
                    Console.WriteLine("Da thoat chuong trinh.");
                    return;

                default:
                    Console.WriteLine("Lua chon khong hop le. Vui long chon lai.");
                    break;
            }
        }
    }
}
