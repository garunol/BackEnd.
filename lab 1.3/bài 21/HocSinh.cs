using System;

public class HocSinh
{
    public string HoTen { get; set; }
    public bool GioiTinh { get; set; } // true: Nam, false: Nu
    public double Toan { get; set; }
    public double Ly { get; set; }
    public double Hoa { get; set; }

    public HocSinh() { }

    public HocSinh(string hoTen, bool gioiTinh, double toan, double ly, double hoa)
    {
        HoTen = hoTen;
        GioiTinh = gioiTinh;
        Toan = toan;
        Ly = ly;
        Hoa = hoa;
    }

    public virtual void Nhap()
    {
        Console.Write("Nhap ho ten: ");
        HoTen = Console.ReadLine();
        Console.Write("Nhap gioi tinh (Nam = true, Nu = false): ");
        GioiTinh = bool.Parse(Console.ReadLine());
        Console.Write("Diem Toan: ");
        Toan = double.Parse(Console.ReadLine());
        Console.Write("Diem Ly: ");
        Ly = double.Parse(Console.ReadLine());
        Console.Write("Diem Hoa: ");
        Hoa = double.Parse(Console.ReadLine());
    }

    public virtual void HienThi()
    {
        Console.WriteLine($"Ho ten: {HoTen}, Gioi tinh: {(GioiTinh ? "Nam" : "Nu")}, Toan: {Toan}, Ly: {Ly}, Hoa: {Hoa}");
    }

    public virtual bool LaNam => GioiTinh;
}
