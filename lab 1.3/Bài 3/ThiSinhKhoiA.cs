public class ThiSinhKhoiA : ThiSinh
{
    public double Toan { get; set; }
    public double Ly { get; set; }
    public double Hoa { get; set; }

    public override void Nhap()
    {
        base.Nhap();
        Toan = NhapDiem("toan");
        Ly = NhapDiem("ly");
        Hoa = NhapDiem("hoa");
    }

    public override double TinhTongDiem()
    {
        return Toan + Ly + Hoa + UuTien;
    }

    public override void HienThi()
    {
        base.HienThi();
        Console.WriteLine($"Khoi A - Toan: {Toan}, Ly: {Ly}, Hoa: {Hoa}, Tong: {TinhTongDiem()}");
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
