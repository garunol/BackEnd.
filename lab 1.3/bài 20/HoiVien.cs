using System;

public class HoiVien
{
    public string HoTen { get; set; }
    public string DiaChi { get; set; }

    public HoiVien() { }

    public HoiVien(string hoTen, string diaChi)
    {
        HoTen = hoTen;
        DiaChi = diaChi;
    }

    public virtual void Nhap()
    {
        Console.Write("Nhap ho ten: ");
        HoTen = Console.ReadLine();
        Console.Write("Nhap dia chi: ");
        DiaChi = Console.ReadLine();
    }

    public virtual void HienThi()
    {
        Console.WriteLine($"Ho ten: {HoTen}, Dia chi: {DiaChi}");
    }

    public virtual bool DaKetHon => false;
    public virtual DateTime? NgayCuoi => null;
    public virtual bool CoNguoiYeu => false;
}
