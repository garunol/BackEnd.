using System;

public class Nguoi
{
    public string HoTen { get; set; }
    public int NamSinh { get; set; }
    public string QueQuan { get; set; }

    public virtual void Nhap()
    {
        Console.Write("Ho ten: ");
        HoTen = Console.ReadLine();

        Console.Write("Nam sinh: ");
        NamSinh = int.Parse(Console.ReadLine());

        Console.Write("Que quan: ");
        QueQuan = Console.ReadLine();
    }

    public virtual void HienThi()
    {
        Console.WriteLine($"Ho ten: {HoTen}, Nam sinh: {NamSinh}, Que quan: {QueQuan}");
    }
}
