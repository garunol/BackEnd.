public class PTGT
{
    public string HangSanXuat { get; set; }
    public int NamSanXuat { get; set; }
    public double GiaBan { get; set; }
    public string Mau { get; set; }

    public PTGT() { }

    public PTGT(string hang, int nam, double gia, string mau)
    {
        HangSanXuat = hang;
        NamSanXuat = nam;
        GiaBan = gia;
        Mau = mau;
    }

    public virtual void Nhap()
    {
        Console.Write("Nhap hang san xuat: ");
        HangSanXuat = Console.ReadLine();
        Console.Write("Nhap nam san xuat: ");
        NamSanXuat = int.Parse(Console.ReadLine());
        Console.Write("Nhap gia ban: ");
        GiaBan = double.Parse(Console.ReadLine());
        Console.Write("Nhap mau: ");
        Mau = Console.ReadLine();
    }

    public virtual void HienThi()
    {
        Console.WriteLine($"Hang: {HangSanXuat}, Nam: {NamSanXuat}, Gia: {GiaBan}, Mau: {Mau}");
    }
}
