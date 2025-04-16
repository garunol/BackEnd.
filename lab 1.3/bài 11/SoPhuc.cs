using System;

public class SoPhuc
{
    public double PhanThuc { get; set; }
    public double PhanAo { get; set; }

    // Constructor không đối
    public SoPhuc()
    {
        PhanThuc = 0;
        PhanAo = 0;
    }

    // Constructor có đối số
    public SoPhuc(double a, double b)
    {
        PhanThuc = a;
        PhanAo = b;
    }

    // Nhập số phức
    public void Nhap()
    {
        Console.Write("Nhap phan thuc: ");
        PhanThuc = double.Parse(Console.ReadLine());
        Console.Write("Nhap phan ao: ");
        PhanAo = double.Parse(Console.ReadLine());
    }

    // Hiển thị số phức
    public void HienThi()
    {
        if (PhanAo >= 0)
            Console.WriteLine($"{PhanThuc} + {PhanAo}i");
        else
            Console.WriteLine($"{PhanThuc} - {Math.Abs(PhanAo)}i");
    }

    // Cộng hai số phức
    public SoPhuc Cong(SoPhuc sp)
    {
        return new SoPhuc(this.PhanThuc + sp.PhanThuc, this.PhanAo + sp.PhanAo);
    }

    // Trừ hai số phức
    public SoPhuc Tru(SoPhuc sp)
    {
        return new SoPhuc(this.PhanThuc - sp.PhanThuc, this.PhanAo - sp.PhanAo);
    }

    // Nhân hai số phức
    public SoPhuc Nhan(SoPhuc sp)
    {
        double thuc = this.PhanThuc * sp.PhanThuc - this.PhanAo * sp.PhanAo;
        double ao = this.PhanThuc * sp.PhanAo + this.PhanAo * sp.PhanThuc;
        return new SoPhuc(thuc, ao);
    }

    // Chia hai số phức
    public SoPhuc Chia(SoPhuc sp)
    {
        double mau = sp.PhanThuc * sp.PhanThuc + sp.PhanAo * sp.PhanAo;
        if (mau == 0)
            throw new DivideByZeroException("Khong the chia cho so phuc co gia tri 0");

        double thuc = (this.PhanThuc * sp.PhanThuc + this.PhanAo * sp.PhanAo) / mau;
        double ao = (this.PhanAo * sp.PhanThuc - this.PhanThuc * sp.PhanAo) / mau;
        return new SoPhuc(thuc, ao);
    }
}
