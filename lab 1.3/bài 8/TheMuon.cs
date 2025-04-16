public class TheMuon
{
    public string SoPhieuMuon { get; set; }
    public DateTime NgayMuon { get; set; }
    public DateTime HanTra { get; set; }
    public string SoHieuSach { get; set; }
    public SinhVien SinhVien { get; set; }

    public TheMuon()
    {
        SinhVien = new SinhVien();
    }

    public void Nhap()
    {
        Console.Write("Nhap so phieu muon: ");
        SoPhieuMuon = Console.ReadLine();

        Console.Write("Nhap ngay muon (yyyy-MM-dd): ");
        NgayMuon = DateTime.Parse(Console.ReadLine());

        Console.Write("Nhap han tra (yyyy-MM-dd): ");
        HanTra = DateTime.Parse(Console.ReadLine());

        Console.Write("Nhap so hieu sach: ");
        SoHieuSach = Console.ReadLine();

        Console.WriteLine("Nhap thong tin sinh vien:");
        SinhVien.Nhap();
    }

    public void HienThi()
    {
        Console.WriteLine($"So phieu muon: {SoPhieuMuon}, Ngay muon: {NgayMuon:yyyy-MM-dd}, Han tra: {HanTra:yyyy-MM-dd}, So hieu sach: {SoHieuSach}");
        SinhVien.HienThi();
    }
}
