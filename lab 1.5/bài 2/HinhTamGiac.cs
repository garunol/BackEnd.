using System;

public class HinhTamGiac : Hinh
{
    public double A, B, C;

    public HinhTamGiac(double a, double b, double c)
    {
        A = a; B = b; C = c;
    }

    public override double TinhChuVi()
    {
        return A + B + C;
    }

    public override double TinhDienTich()
    {
        double p = TinhChuVi() / 2;
        return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
    }
}
