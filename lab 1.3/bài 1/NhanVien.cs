using System;

public class NhanVien : CanBo
{
    public string CongViec { get; set; }

    public override void Nhap()
    {
        base.Nhap();
        Console.Write("Cong viec: ");
        CongViec = Console.ReadLine();
    }

    public override void HienThi()
    {
        base.HienThi();
        Console.WriteLine($"Cong viec: {CongViec}");
    }
}
