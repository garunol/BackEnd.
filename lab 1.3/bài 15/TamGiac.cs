using System;

class TamGiac : DaGiac
{
    public TamGiac() : base(3) { }

    public override void Nhap()
    {
        soCanh = 3;
        kichThuoc = new int[3];
        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Nhập độ dài cạnh {i + 1}: ");
            kichThuoc[i] = int.Parse(Console.ReadLine());
        }
    }

    public override int TinhChuVi()
    {
        return kichThuoc[0] + kichThuoc[1] + kichThuoc[2];
    }

    public double TinhDienTich()
    {
        double p = TinhChuVi() / 2.0;
        double a = kichThuoc[0];
        double b = kichThuoc[1];
        double c = kichThuoc[2];
        return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    }

    public bool LaTamGiacVuong()
    {
        Array.Sort(kichThuoc);
        int a = kichThuoc[0];
        int b = kichThuoc[1];
        int c = kichThuoc[2];
        return a * a + b * b == c * c;
    }
}
