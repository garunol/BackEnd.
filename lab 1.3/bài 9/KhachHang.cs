public class KhachHang
{
    public string HoTenChuHo { get; set; }
    public string SoNha { get; set; }
    public string MaCongTo { get; set; }

    public void Nhap()
    {
        Console.Write("Nhap ho ten chu ho: ");
        HoTenChuHo = Console.ReadLine();

        Console.Write("Nhap so nha: ");
        SoNha = Console.ReadLine();

        Console.Write("Nhap ma cong to: ");
        MaCongTo = Console.ReadLine();
    }

    public void HienThi()
    {
        Console.WriteLine($"Chu ho: {HoTenChuHo}, So nha: {SoNha}, Ma cong to: {MaCongTo}");
    }
}
