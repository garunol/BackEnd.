public class OTo : PTGT
{
    public int SoChoNgoi { get; set; }
    public string KieuDongCo { get; set; }

    public override void Nhap()
    {
        base.Nhap();
        Console.Write("Nhap so cho ngoi: ");
        SoChoNgoi = int.Parse(Console.ReadLine());
        Console.Write("Nhap kieu dong co: ");
        KieuDongCo = Console.ReadLine();
    }

    public override void HienThi()
    {
        base.HienThi();
        Console.WriteLine($"So cho ngoi: {SoChoNgoi}, Kieu dong co: {KieuDongCo}");
    }
}
