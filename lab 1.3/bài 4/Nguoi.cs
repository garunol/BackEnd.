public class Nguoi
{
    public string SoCMND { get; set; }
    public string HoTen { get; set; }
    public int Tuoi { get; set; }
    public int NamSinh { get; set; }
    public string NgheNghiep { get; set; }

    public void NhapThongTin()
    {
        Console.Write("Nhap ho ten: ");
        HoTen = Console.ReadLine();

        Console.Write("Nhap so CMND: ");
        SoCMND = Console.ReadLine();

        Console.Write("Nhap tuoi: ");
        Tuoi = int.Parse(Console.ReadLine());

        Console.Write("Nhap nam sinh: ");
        NamSinh = int.Parse(Console.ReadLine());

        Console.Write("Nhap nghe nghiep: ");
        NgheNghiep = Console.ReadLine();
    }

    public void HienThiThongTin()
    {
        Console.WriteLine($"Ho ten: {HoTen}, CMND: {SoCMND}, Tuoi: {Tuoi}, Nam sinh: {NamSinh}, Nghe nghiep: {NgheNghiep}");
    }
}
