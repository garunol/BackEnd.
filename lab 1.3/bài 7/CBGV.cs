public class CBGV
{
    public Nguoi ThongTinCaNhan { get; set; }
    public double LuongCung { get; set; }
    public double Thuong { get; set; }
    public double Phat { get; set; }

    public double LuongThucLinh
    {
        get { return LuongCung + Thuong - Phat; }
    }

    public CBGV()
    {
        ThongTinCaNhan = new Nguoi();
    }

    public void Nhap()
    {
        Console.WriteLine("\nNhap thong tin can bo giao vien:");
        ThongTinCaNhan.Nhap();

        Console.Write("Nhap luong cung: ");
        LuongCung = double.Parse(Console.ReadLine());

        Console.Write("Nhap tien thuong: ");
        Thuong = double.Parse(Console.ReadLine());

        Console.Write("Nhap tien phat: ");
        Phat = double.Parse(Console.ReadLine());
    }

    public void HienThi()
    {
        ThongTinCaNhan.HienThi();
        Console.WriteLine($"Luong cung: {LuongCung}, Thuong: {Thuong}, Phat: {Phat}, Luong thuc linh: {LuongThucLinh}");
    }
}
