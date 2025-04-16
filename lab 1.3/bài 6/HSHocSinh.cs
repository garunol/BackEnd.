public class HSHocSinh
{
    public Nguoi ThongTinCaNhan { get; set; }
    public string Lop { get; set; }
    public string KhoaHoc { get; set; }
    public string KyHoc { get; set; }

    public HSHocSinh()
    {
        ThongTinCaNhan = new Nguoi();
    }

    public void Nhap()
    {
        Console.WriteLine("\nNhap thong tin ho so hoc sinh:");
        ThongTinCaNhan.Nhap();

        Console.Write("Nhap lop: ");
        Lop = Console.ReadLine();

        Console.Write("Nhap khoa hoc: ");
        KhoaHoc = Console.ReadLine();

        Console.Write("Nhap ky hoc: ");
        KyHoc = Console.ReadLine();
    }

    public void HienThi()
    {
        ThongTinCaNhan.HienThi();
        Console.WriteLine($"Lop: {Lop}, Khoa hoc: {KhoaHoc}, Ky hoc: {KyHoc}");
    }
}
