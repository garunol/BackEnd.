using System;

public class HoiVienDaKetHon : HoiVien
{
    public string TenVo { get; set; }
    public DateTime NgayKetHon { get; set; }

    public override void Nhap()
    {
        base.Nhap();
        Console.Write("Nhap ten vo/chong: ");
        TenVo = Console.ReadLine();
        Console.Write("Nhap ngay cuoi (dd/MM/yyyy): ");
        NgayKetHon = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
    }

    public override void HienThi()
    {
        base.HienThi();
        Console.WriteLine($"Da ket hon voi: {TenVo}, Ngay cuoi: {NgayKetHon:dd/MM/yyyy}");
    }

    public override bool DaKetHon => true;
    public override DateTime? NgayCuoi => NgayKetHon;
}
