public class ThiSinhKhoiB : ThiSinh
{
    public double Toan { get; set; }
    public double Hoa { get; set; }
    public double Sinh { get; set; }

    public override void Nhap()
    {
        base.Nhap();
        Toan = NhapDiem("toan");
        Hoa = NhapDiem("hoa");
        Sinh = NhapDiem("sinh");
    }

    public override double TinhTongDiem()
    {
        return Toan + Hoa + Sinh + UuTien;
    }

    public override void HienThi()
    {
        base.HienThi();
        Console.WriteLine($"Khoi B - Toan: {Toan}, Hoa: {Hoa}, Sinh: {Sinh}, Tong: {TinhTongDiem()}");
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
