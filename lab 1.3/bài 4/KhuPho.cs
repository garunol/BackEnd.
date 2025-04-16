public class KhuPho
{
    private List<HoDan> DanhSachHoDan = new List<HoDan>();

    public void NhapDanhSach()
    {
        Console.Write("Nhap so ho dan: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\nNhap thong tin ho dan thu {i + 1}:");
            HoDan hoDan = new HoDan();
            hoDan.NhapThongTin();
            DanhSachHoDan.Add(hoDan);
        }
    }

    public void HienThiTatCa()
    {
        Console.WriteLine("\n--- Danh sach ho dan trong khu pho ---");
        foreach (var hoDan in DanhSachHoDan)
        {
            hoDan.HienThiThongTin();
            Console.WriteLine("-----------------------");
        }
    }

    public void TimKiemTheoTen(string ten)
    {
        var ketQua = DanhSachHoDan.Where(h => h.TimTheoTen(ten)).ToList();
        if (ketQua.Count > 0)
        {
            Console.WriteLine($"\nKet qua tim kiem theo ten \"{ten}\":");
            foreach (var hoDan in ketQua)
            {
                hoDan.HienThiThongTin();
                Console.WriteLine("-----------------------");
            }
        }
        else
        {
            Console.WriteLine("Khong tim thay ho dan nao theo ten nay.");
        }
    }

    public void TimKiemTheoSoNha(string soNha)
    {
        var ketQua = DanhSachHoDan.FirstOrDefault(h => h.SoNha.Equals(soNha, StringComparison.OrdinalIgnoreCase));
        if (ketQua != null)
        {
            Console.WriteLine($"\nThong tin ho dan co so nha {soNha}:");
            ketQua.HienThiThongTin();
        }
        else
        {
            Console.WriteLine("Khong tim thay ho dan co so nha nay.");
        }
    }
}
