using System;

public class HinhTron : Hinh
{
    public double BanKinh { get; set; }

    public HinhTron(double r)
    {
        BanKinh = r;
    }

    public override double TinhChuVi()
    {
        return 2 * Math.PI * BanKinh;
    }

    public override double TinhDienTich()
    {
        return Math.PI * BanKinh * BanKinh;
    }
}
