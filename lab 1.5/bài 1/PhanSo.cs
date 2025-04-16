using System;

public class PhanSo
{
    public int TuSo { get; set; }
    public int MauSo { get; set; }

    public PhanSo()
    {
        TuSo = 0;
        MauSo = 1;
    }

    public PhanSo(int tu, int mau)
    {
        TuSo = tu;
        MauSo = mau != 0 ? mau : 1;
    }

    public void Nhap()
    {
        Console.Write("Nhap tu so: ");
        TuSo = int.Parse(Console.ReadLine());
        Console.Write("Nhap mau so: ");
        MauSo = int.Parse(Console.ReadLine());

        if (MauSo == 0)
        {
            Console.WriteLine("Mau so khong duoc bang 0. Dat lai mau so = 1");
            MauSo = 1;
        }
    }

    public static PhanSo Cong(PhanSo a, PhanSo b)
    {
        int tu = a.TuSo * b.MauSo + b.TuSo * a.MauSo;
        int mau = a.MauSo * b.MauSo;
        return RutGon(new PhanSo(tu, mau));
    }

    public static PhanSo RutGon(PhanSo ps)
    {
        int ucln = UCLN(Math.Abs(ps.TuSo), Math.Abs(ps.MauSo));
        ps.TuSo /= ucln;
        ps.MauSo /= ucln;
        return ps;
    }

    private static int UCLN(int a, int b)
    {
        while (b != 0)
        {
            int t = b;
            b = a % b;
            a = t;
        }
        return a;
    }

    public override string ToString()
    {
        return TuSo + "/" + MauSo;
    }
}
