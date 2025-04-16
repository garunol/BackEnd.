using System;

class TamGiac
{
    private Diem A, B, C;

    public TamGiac()
    {
        A = new Diem();
        B = new Diem();
        C = new Diem();
    }

    public TamGiac(Diem a, Diem b, Diem c)
    {
        A = a;
        B = b;
        C = c;
    }

    public void Nhap()
    {
        Console.WriteLine("Nhập điểm A:");
        A.Nhap();
        Console.WriteLine("Nhập điểm B:");
        B.Nhap();
        Console.WriteLine("Nhập điểm C:");
        C.Nhap();
    }

    public double TinhChuVi()
    {
        double ab = A.TinhKhoangCach(B);
        double bc = B.TinhKhoangCach(C);
        double ca = C.TinhKhoangCach(A);
        return ab + bc + ca;
    }

    public double TinhDienTich()
    {
        double ab = A.TinhKhoangCach(B);
        double bc = B.TinhKhoangCach(C);
        double ca = C.TinhKhoangCach(A);
        double p = (ab + bc + ca) / 2;
        return Math.Sqrt(p * (p - ab) * (p - bc) * (p - ca));
    }

    public void HienThi()
    {
        Console.Write("Tam giác với các điểm: ");
        A.HienThi(); Console.Write(" ");
        B.HienThi(); Console.Write(" ");
        C.HienThi(); Console.WriteLine();
    }
}
