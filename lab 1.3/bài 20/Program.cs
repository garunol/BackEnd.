using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<HoiVien> danhSach = new List<HoiVien>();
        int n;

        Console.Write("Nhap so luong hoi vien: ");
        while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
        {
            Console.Write("Vui long nhap so nguyen duong: ");
        }

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\n--- Nhap thong tin hoi vien thu {i + 1} ---");
            Console.WriteLine("1. Da ket hon");
            Console.WriteLine("2. Co nguoi yeu");
            Console.WriteLine("3. Chua co nguoi yeu");
            Console.Write("Chon loai hoi vien (1/2/3): ");
            int loai;
            while (!int.TryParse(Console.ReadLine(), out loai) || loai < 1 || loai > 3)
            {
                Console.Write("Nhap lai dung (1-3): ");
            }

            HoiVien hv;
            if (loai == 1)
                hv = new HoiVienDaKetHon();
            else if (loai == 2)
                hv = new HoiVienCoNguoiYeu();
            else
                hv = new HoiVien();

            hv.Nhap();
            danhSach.Add(hv);
        }

        // 3. Tim ngay cuoi la 11/11/2011
        Console.WriteLine("\n--- Hoi vien ket hon ngay 11/11/2011 ---");
        DateTime ngayMucTieu = new DateTime(2011, 11, 11);
        var ketHonDiem = danhSach.Where(hv => hv.DaKetHon && hv.NgayCuoi == ngayMucTieu).ToList();

        if (ketHonDiem.Count == 0)
            Console.WriteLine("Khong co ai ket hon ngay 11/11/2011.");
        else
            ketHonDiem.ForEach(hv => hv.HienThi());

        // 4. Co nguoi yeu nhung chua ket hon
        Console.WriteLine("\n--- Hoi vien co nguoi yeu nhung chua ket hon ---");
        var coNYChuaCuoi = danhSach.Where(hv => hv.CoNguoiYeu && !hv.DaKetHon).ToList();

        if (coNYChuaCuoi.Count == 0)
            Console.WriteLine("Khong co ai co nguoi yeu nhung chua ket hon.");
        else
            coNYChuaCuoi.ForEach(hv => hv.HienThi());
    }
}
