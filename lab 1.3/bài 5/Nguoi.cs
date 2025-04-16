public class Nguoi
{
    public string HoTen { get; set; }
    public int NamSinh { get; set; }
    public string CMND { get; set; }

    public virtual void Nhap()
    {
        Console.Write("Nhap ho ten: ");
        HoTen = Console.ReadLine();

        Console.Write("Nhap nam sinh: ");
        NamSinh = int.Parse(Console.ReadLine());

        Console.Write("Nhap so CMND: ");
        CMND = Console.ReadLine();
    }

    public virtual void HienThi()
    {
        Console.WriteLine($"Ho ten: {HoTen}, Nam sinh: {NamSinh}, CMND: {CMND}");
    }
}
