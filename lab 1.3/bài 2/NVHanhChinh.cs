using System;

public class NVHanhChinh : Nguoi
{
    public string CongViec { get; set; }
    public int SoNgayCong { get; set; }

    public override void Nhap()
    {
        base.Nhap();
        Console.Write("Cong viec: ");
        CongViec = Console.ReadLine();

        Console.Write("So ngay cong trong thang: ");
        SoNgayCong = int.Parse(Console.ReadLine());
    }

    public override void HienThi()
    {
        base.HienThi();
        Console.WriteLine($"Cong viec: {CongViec}, So ngay cong: {SoNgayCong}");
    }
}
