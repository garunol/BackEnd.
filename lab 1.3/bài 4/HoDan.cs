public class HoDan
{
    public int SoThanhVien { get; set; }
    public string SoNha { get; set; }
    public List<Nguoi> DanhSachNguoi { get; set; } = new List<Nguoi>();

    public void NhapThongTin()
    {
        Console.Write("Nhap so nha: ");
        SoNha = Console.ReadLine();

        Console.Write("Nhap so thanh vien: ");
        SoThanhVien = int.Parse(Console.ReadLine());

        for (int i = 0; i < SoThanhVien; i++)
        {
            Console.WriteLine($"Nhap thong tin cho thanh vien thu {i + 1}: ");
            Nguoi nguoi = new Nguoi();
            nguoi.NhapThongTin();
            DanhSachNguoi.Add(nguoi);
        }
    }

    public void HienThiThongTin()
    {
        Console.WriteLine($"So nha: {SoNha}, So thanh vien: {SoThanhVien}");
        foreach (var nguoi in DanhSachNguoi)
        {
            nguoi.HienThiThongTin();
        }
    }

    public bool TimTheoTen(string ten)
    {
        return DanhSachNguoi.Any(n => n.HoTen.ToLower().Contains(ten.ToLower()));
    }
}
