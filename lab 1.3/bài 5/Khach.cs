public class Khach : Nguoi
{
    public int SoNgayTro { get; set; }
    public string LoaiPhong { get; set; }
    public double GiaPhong { get; set; }

    public override void Nhap()
    {
        base.Nhap();

        Console.Write("Nhap so ngay tro: ");
        SoNgayTro = int.Parse(Console.ReadLine());

        Console.Write("Nhap loai phong (A/B/C): ");
        LoaiPhong = Console.ReadLine();

        Console.Write("Nhap gia phong: ");
        GiaPhong = double.Parse(Console.ReadLine());
    }

    public override void HienThi()
    {
        base.HienThi();
        Console.WriteLine($"Loai phong: {LoaiPhong}, So ngay tro: {SoNgayTro}, Gia phong: {GiaPhong} VND");
    }

    public double TinhTien()
    {
        return SoNgayTro * GiaPhong;
    }
}
