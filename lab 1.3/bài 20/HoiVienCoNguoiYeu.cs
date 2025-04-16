using System;

public class HoiVienCoNguoiYeu : HoiVien
{
    public string TenNguoiYeu { get; set; }
    public string SDTNguoiYeu { get; set; }

    public override void Nhap()
    {
        base.Nhap();
        Console.Write("Nhap ten nguoi yeu: ");
        TenNguoiYeu = Console.ReadLine();
        Console.Write("Nhap SDT nguoi yeu: ");
        SDTNguoiYeu = Console.ReadLine();
    }

    public override void HienThi()
    {
        base.HienThi();
        Console.WriteLine($"Co nguoi yeu: {TenNguoiYeu}, SDT: {SDTNguoiYeu}");
    }

    public override bool CoNguoiYeu => true;
}
