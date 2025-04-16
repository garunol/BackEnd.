using System;

public class GiaoVien : Nguoi
{
    public string MonGiangDay { get; set; }
    public int SoTietDay { get; set; }

    public override void Nhap()
    {
        base.Nhap();
        Console.Write("Mon giang day: ");
        MonGiangDay = Console.ReadLine();

        Console.Write("So tiet day trong thang: ");
        SoTietDay = int.Parse(Console.ReadLine());
    }

    public override void HienThi()
    {
        base.HienThi();
        Console.WriteLine($"Mon giang day: {MonGiangDay}, So tiet: {SoTietDay}");
    }
}
