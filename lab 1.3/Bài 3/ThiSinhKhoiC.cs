public class ThiSinhKhoiC : ThiSinh
{
    public double Van { get; set; }
    public double Su { get; set; }
    public double Dia { get; set; }

    public override void Nhap()
    {
        base.Nhap();
        Van = NhapDiem("van");
        Su = NhapDiem("su");
        Dia = NhapDiem("dia");
    }

    public override double TinhTongDiem()
    {
        return Van + Su + Dia + UuTien;
    }

    public override void HienThi()
    {
        base.HienThi();
        Console.WriteLine($"Khoi C - Van: {Van}, Su: {Su}, Dia: {Dia}, Tong: {TinhTongDiem()}");
    }

    private double NhapDiem(string mon)
    {
        while (true)
        {
            Console.Write($"Nhap diem {mon}: ");
            if (double.TryParse(Console.ReadLine(), out double diem))
                return diem;
            else
                Console.WriteLine("Nhap sai, nhap lai.");
        }
    }
}
