public class BienLai
{
    public KhachHang Khach { get; set; }
    public int ChiSoCu { get; set; }
    public int ChiSoMoi { get; set; }

    public BienLai()
    {
        Khach = new KhachHang();
    }

    public void Nhap()
    {
        Console.WriteLine("Nhap thong tin khach hang:");
        Khach.Nhap();

        Console.Write("Nhap chi so cu: ");
        ChiSoCu = int.Parse(Console.ReadLine());

        Console.Write("Nhap chi so moi: ");
        ChiSoMoi = int.Parse(Console.ReadLine());

        while (ChiSoMoi < ChiSoCu)
        {
            Console.WriteLine("Chi so moi phai lon hon chi so cu. Nhap lai:");
            Console.Write("Nhap chi so moi: ");
            ChiSoMoi = int.Parse(Console.ReadLine());
        }
    }

    public int SoDien()
    {
        return ChiSoMoi - ChiSoCu;
    }

    public double TinhTien()
    {
        int soDien = SoDien();
        double tien = 0;

        if (soDien <= 50)
        {
            tien = soDien * 1250;
        }
        else if (soDien < 100)
        {
            tien = 50 * 1250 + (soDien - 50) * 1500;
        }
        else
        {
            tien = 50 * 1250 + 50 * 1500 + (soDien - 100) * 2000;
        }

        return tien;
    }

    public void HienThi()
    {
        Khach.HienThi();
        Console.WriteLine($"Chi so cu: {ChiSoCu}, Chi so moi: {ChiSoMoi}, So dien: {SoDien()}, Tien phai tra: {TinhTien():N0} VND");
    }
}
