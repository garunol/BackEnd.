using System;

public class CanBo
{
    public string HoTen { get; set; }
    public int NamSinh { get; set; }
    public string GioiTinh { get; set; }
    public string DiaChi { get; set; }

    public virtual void Nhap()
    {
        Console.Write("Ho ten: ");
        HoTen = Console.ReadLine();

        Console.Write("Nam sinh: ");
        NamSinh = int.Parse(Console.ReadLine());

        Console.Write("Gioi tinh: ");
        GioiTinh = Console.ReadLine();

        Console.Write("Dia chi: ");
        DiaChi = Console.ReadLine();
    }

    public virtual void HienThi()
    {
        Console.WriteLine($"Ho ten: {HoTen}, Nam sinh: {NamSinh}, Gioi tinh: {GioiTinh}, Dia chi: {DiaChi}");
    }
}
