public class XeMay : PTGT
{
    public double CongSuat { get; set; }

    public override void Nhap()
    {
        base.Nhap();
        Console.Write("Nhap cong suat: ");
        CongSuat = double.Parse(Console.ReadLine());
    }

    public override void HienThi()
    {
        base.HienThi();
        Console.WriteLine($"Cong suat: {CongSuat}");
    }
}
