using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main()
    {
        List<TheMuon> danhSachTheMuon = new List<TheMuon>();

        while (true)
        {
            Console.WriteLine("\n====== MENU ======");
            Console.WriteLine("1. Nhap danh sach the muon");
            Console.WriteLine("2. Tim sinh vien theo ma sinh vien");
            Console.WriteLine("3. Hien thi sinh vien den han tra sach");
            Console.WriteLine("4. Thoat");
            Console.Write("Chon chuc nang: ");
            int chon = int.Parse(Console.ReadLine());

            switch (chon)
            {
                case 1:
                    Console.Write("Nhap so luong the muon: ");
                    int n = int.Parse(Console.ReadLine());
                    for (int i = 0; i < n; i++)
                    {
                        Console.WriteLine($"\nNhap the muon thu {i + 1}:");
                        TheMuon tm = new TheMuon();
                        tm.Nhap();
                        danhSachTheMuon.Add(tm);
                    }
                    break;

                case 2:
                    Console.Write("Nhap ma sinh vien can tim: ");
                    string maSV = Console.ReadLine().ToLower();
                    var ketQua = danhSachTheMuon
                        .Where(tm => tm.SinhVien.MaSV.ToLower() == maSV)
                        .ToList();

                    if (ketQua.Any())
                    {
                        Console.WriteLine("\nThong tin sinh vien:");
                        foreach (var tm in ketQua)
                            tm.HienThi();
                    }
                    else
                        Console.WriteLine("Khong tim thay sinh vien.");
                    break;

                case 3:
                    DateTime ngayHienTai = DateTime.Today;
                    var denHan = danhSachTheMuon
                        .Where(tm => tm.HanTra <= ngayHienTai)
                        .ToList();

                    Console.WriteLine("\nDanh sach sinh vien den han tra sach:");
                    foreach (var tm in denHan)
                        tm.HienThi();
                    break;

                case 4:
                    return;

                default:
                    Console.WriteLine("Lua chon khong hop le.");
                    break;
            }
        }
    }
}
