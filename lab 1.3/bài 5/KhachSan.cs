public class KhachSan
{
    private List<Khach> danhSachKhach = new List<Khach>();

    public void NhapDanhSach()
    {
        Console.Write("Nhap so luong khach tro: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\nNhap thong tin khach thu {i + 1}:");
            Khach khach = new Khach();
            khach.Nhap();
            danhSachKhach.Add(khach);
        }
    }

    public void HienThiTatCa()
    {
        Console.WriteLine("\nDanh sach khach tro:");
        foreach (var khach in danhSachKhach)
        {
            khach.HienThi();
            Console.WriteLine($"=> Tong tien: {khach.TinhTien()} VND\n");
        }
    }

    public void TimKiemTheoTen(string ten)
    {
        var ketQua = danhSachKhach.Where(k => k.HoTen.ToLower().Contains(ten.ToLower())).ToList();
        if (ketQua.Count == 0)
        {
            Console.WriteLine("Khong tim thay khach nao.");
        }
        else
        {
            Console.WriteLine("\nKet qua tim kiem:");
            foreach (var k in ketQua)
            {
                k.HienThi();
                Console.WriteLine($"=> Tong tien: {k.TinhTien()} VND\n");
            }
        }
    }
    public void TinhTienKhachHang()
    {
        Console.Write("Nhap ho ten hoac so CMND cua khach can tinh tien: ");
        string input = Console.ReadLine().ToLower();

        var khach = danhSachKhach.FirstOrDefault(k =>
            k.HoTen.ToLower().Contains(input) || k.CMND.ToLower() == input);

        if (khach != null)
        {
            Console.WriteLine("\nThong tin khach hang:");
            khach.HienThi();
            double tongTien = khach.TinhTien();
            Console.WriteLine($"Tong tien phai thanh toan: {tongTien} VND");
        }
        else
        {
            Console.WriteLine("Khong tim thay khach hang.");
        }
    }

}
