public class HocSinhNu : HocSinh
{
    public double NuCong { get; set; }

    public override void Nhap()
    {
        base.Nhap();
        Console.Write("Diem Nu Cong: ");
        NuCong = double.Parse(Console.ReadLine());
    }

    public override void HienThi()
    {
        base.HienThi();
        Console.WriteLine($"Diem Nu Cong: {NuCong}");
    }
}
