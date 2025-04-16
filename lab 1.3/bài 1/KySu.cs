using System;

public class KySu : CanBo
{
    public string NganhDaoTao { get; set; }

    public override void Nhap()
    {
        base.Nhap();
        Console.Write("Nganh dao tao: ");
        NganhDaoTao = Console.ReadLine();
    }

    public override void HienThi()
    {
        base.HienThi();
        Console.WriteLine($"Nganh dao tao: {NganhDaoTao}");
    }
}
