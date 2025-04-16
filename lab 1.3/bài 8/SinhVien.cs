public class SinhVien
{
    public string HoTen { get; set; }
    public int NamSinh { get; set; }
    public string Lop { get; set; }
    public string MaSV { get; set; }

    public void Nhap()
    {
        Console.Write("Nhap ho ten: ");
        HoTen = Console.ReadLine();

        Console.Write("Nhap nam sinh: ");
        NamSinh = int.Parse(Console.ReadLine());

        Console.Write("Nhap lop: ");
        Lop = Console.ReadLine();

        Console.Write("Nhap ma sinh vien: ");
        MaSV = Console.ReadLine();
    }

    public void HienThi()
    {
        Console.WriteLine($"Ho ten: {HoTen}, Nam sinh: {NamSinh}, Lop: {Lop}, Ma SV: {MaSV}");
    }
}
