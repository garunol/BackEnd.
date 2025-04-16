using System;

class HinhTron
{
    public Diem tam;
    public double banKinh;

    public HinhTron()
    {
        tam = new Diem();
        banKinh = 0;
    }

    public HinhTron(Diem d, double r)
    {
        tam = d;
        banKinh = r;
    }

    public void Nhap()
    {
        Console.WriteLine("Nhập tọa độ tâm:");
        tam.Nhap();
        Console.Write("Nhập bán kính: ");
        banKinh = double.Parse(Console.ReadLine());
    }

    public void HienThi()
    {
        Console.Write("Tâm: ");
        tam.HienThi();
        Console.WriteLine($", Bán kính: {banKinh}");
    }

    public double TinhChuVi()
    {
        return 2 * Math.PI * banKinh;
    }

    public double TinhDienTich()
    {
        return Math.PI * banKinh * banKinh;
    }

    public bool GiaoNhau(HinhTron ht2)
    {
        double kcTam = tam.KhoangCach(ht2.tam);
        return kcTam <= (this.banKinh + ht2.banKinh) && kcTam >= Math.Abs(this.banKinh - ht2.banKinh);
    }
}
