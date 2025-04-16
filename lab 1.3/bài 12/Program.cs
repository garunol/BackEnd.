using System;

public class Program
{
    public static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("Nhập ma trận A:");
        MaTran A = new MaTran();
        A.Nhap();

        Console.WriteLine("\nNhập ma trận B:");
        MaTran B = new MaTran();
        B.Nhap();

        while (true)
        {
            Console.WriteLine("\n===== MENU =====");
            Console.WriteLine("a. Tính tổng hai ma trận");
            Console.WriteLine("b. Tính hiệu hai ma trận");
            Console.WriteLine("c. Tính tích hai ma trận");
            Console.WriteLine("d. Tính thương hai ma trận (chia từng phần tử)");
            Console.WriteLine("e. Thoát");
            Console.Write("Chọn chức năng: ");
            string chon = Console.ReadLine();

            try
            {
                MaTran kq = null;
                switch (chon.ToLower())
                {
                    case "a":
                        kq = A.Cong(B);
                        Console.WriteLine("Tổng A + B:");
                        kq.HienThi();
                        break;

                    case "b":
                        kq = A.Tru(B);
                        Console.WriteLine("Hiệu A - B:");
                        kq.HienThi();
                        break;

                    case "c":
                        kq = A.Nhan(B);
                        Console.WriteLine("Tích A * B:");
                        kq.HienThi();
                        break;

                    case "d":
                        kq = A.Chia(B);
                        Console.WriteLine("Thương A / B:");
                        kq.HienThi();
                        break;

                    case "e":
                        Console.WriteLine("Đã thoát chương trình.");
                        return;

                    default:
                        Console.WriteLine("Chức năng không hợp lệ, vui lòng chọn lại.");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
            }
        }
    }
}
