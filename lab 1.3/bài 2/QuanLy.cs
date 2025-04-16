using System;
using System.Collections.Generic;
using System.Linq;

public class QuanLy
{
    private List<Nguoi> DanhSach = new List<Nguoi>();

    public void NhapDanhSach()
    {
        Console.Write("Nhap so luong nguoi: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("\nChon loai nguoi:");
            Console.WriteLine("1. Sinh vien");
            Console.WriteLine("2. Giao vien");
            Console.WriteLine("3. Nhan vien hanh chinh");
            Console.Write("Lua chon: ");
            int loai = int.Parse(Console.ReadLine());

            Nguoi nguoi = null;
            switch (loai)
            {
                case 1: nguoi = new SinhVien(); break;
                case 2: nguoi = new GiaoVien(); break;
                case 3: nguoi = new NVHanhChinh(); break;
                default:
                    Console.WriteLine("Lua chon khong hop le.");
                    continue;
            }

            Console.WriteLine("Nhap thong tin:");
            nguoi.Nhap();
            DanhSach.Add(nguoi);
        }
    }

    public void HienThiDanhSach()
    {
        Console.WriteLine("\nDanh sach:");
        foreach (var nguoi in DanhSach)
        {
            nguoi.HienThi();
            Console.WriteLine();
        }
    }

    public void TimKiemTheoHoTen()
    {
        Console.Write("Nhap ho ten can tim: ");
        string ten = Console.ReadLine();
        var ketQua = DanhSach.Where(n => n.HoTen.Contains(ten)).ToList();

        if (ketQua.Count == 0)
        {
            Console.WriteLine("Khong tim thay.");
        }
        else
        {
            Console.WriteLine("Ket qua tim kiem:");
            foreach (var n in ketQua)
            {
                n.HienThi();
                Console.WriteLine();
            }
        }
    }
}
