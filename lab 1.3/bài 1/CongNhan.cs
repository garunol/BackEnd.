using System;

public class CongNhan : CanBo
{
    public string Bac { get; set; }

    public override void Nhap()
    {
        base.Nhap();
        Console.Write("Bac (vi du 3/7): ");
        Bac = Console.ReadLine();
    }

    public override void HienThi()
    {
        base.HienThi();
        Console.WriteLine($"Bac: {Bac}");
    }
}
