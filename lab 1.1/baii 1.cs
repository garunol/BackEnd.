using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string name;
        int age;

        try
        {
            Console.Write("Nhap ten cua ban: ");
            name = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Loi: Ten cua ban khong duoc de trong!");
                return;
            }

            // Regex kiểm tra xem người dùng có nhập toàn là số không
            if (Regex.IsMatch(name.Trim(), @"^\d+$"))
            {
                Console.WriteLine("Loi: Ten khong duoc chi chua so! Vui long nhap ten hop le.");
                return;
            }

            Console.Write("Nhap tuoi cua ban: ");
            string ageInput = Console.ReadLine();

            if (!int.TryParse(ageInput, out age) || age <= 0)
            {
                Console.WriteLine("Loi: Tuoi phai la so nguyen duong!");
                return;
            }

            Console.WriteLine($"✅ Xin chao {name}, ban {age} tuoi!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("❌ Da xay ra loi he thong: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("🧾 Chuong trinh ket thuc.");
        }
    }
}
