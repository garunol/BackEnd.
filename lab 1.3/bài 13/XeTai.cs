public class XeTai : PTGT
{
    public double TrongTai { get; set; }

    public override void Nhap()
    {
        base.Nhap();
        Console.Write("Nhap trong tai: ");
        TrongTai = double.Parse(Console.ReadLine());
    }

    public override void HienThi()
    {
        base.HienThi();
        Console.WriteLine($"Trong tai: {TrongTai}");
    }
}
