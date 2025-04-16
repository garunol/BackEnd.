public class HocSinhNam : HocSinh
{
    public double KyThuat { get; set; }

    public override void Nhap()
    {
        base.Nhap();
        Console.Write("Diem Ky Thuat: ");
        KyThuat = double.Parse(Console.ReadLine());
    }

    public override void HienThi()
    {
        base.HienThi();
        Console.WriteLine($"Diem Ky Thuat: {KyThuat}");
    }
}
