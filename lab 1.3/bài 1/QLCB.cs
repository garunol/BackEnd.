using System;
using System.Collections.Generic;
using System.Linq;

public class QLCB
{
    private List<CanBo> DanhSach = new List<CanBo>();

    public void NhapThongTin()
    {
        Console.Write("Nhap so luong can bo: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("\nChon loai can bo:");
            Console.WriteLine("1. Cong nhan");
            Console.WriteLine("2. Ky su");
            Console.WriteLine("3. Nhan vien");
            Console.Write("Lua chon: ");
            int loai = int.Parse(Console.ReadLine());

            CanBo cb = null;
            switch (loai)
            {
                case 1: cb = new CongNhan(); break;
                case 2: cb = new KySu(); break;
                case 3: cb = new NhanVien(); break;
                default:
                    Console.WriteLine("Lua chon khong hop le.");
                    continue;
            }

            Console.WriteLine("Nhap thong tin:");
            cb.Nhap();
            DanhSach.Add(cb);
        }
    }

    public void TimKiemTheoHoTen()
    {
        Console.Write("Nhap ho ten can tim: ");
        string ten = Console.ReadLine();
        var ketQua = DanhSach.Where(cb => cb.HoTen.Contains(ten)).ToList();

        if (ketQua.Count == 0)
        {
            Console.WriteLine("Khong tim thay.");
        }
        else
        {
            Console.WriteLine("Ket qua tim kiem:");
            foreach (var cb in ketQua)
            {
                cb.HienThi();
                Console.WriteLine();
            }
        }
    }

    public void HienThiDanhSach()
    {
        Console.WriteLine("Danh sach can bo:");
        foreach (var cb in DanhSach)
        {
            cb.HienThi();
            Console.WriteLine();
        }
    }
}
