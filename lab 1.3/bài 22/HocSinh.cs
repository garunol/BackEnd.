using System;
using System.Globalization;

public class HocSinh
{
    public string HoTen { get; set; }
    public int NamSinh { get; set; }
    public double TongDiem { get; set; }

    public HocSinh() { }

    public HocSinh(string hoTen, int namSinh, double tongDiem)
    {
        HoTen = hoTen;
        NamSinh = namSinh;
        TongDiem = tongDiem;
    }

    public void Nhap()
    {
        Console.Write("Nhap ho ten: ");
        HoTen = Console.ReadLine();

        Console.Write("Nhap nam sinh: ");
        int nam;
        while (!int.TryParse(Console.ReadLine(), out nam) || nam <= 1900 || nam > DateTime.Now.Year)
        {
            Console.Write("Nam sinh khong hop le. Nhap lai: ");
        }
        NamSinh = nam;

        Console.Write("Nhap tong điem: ");
        double diem;
        while (!double.TryParse(Console.ReadLine(), out diem) || diem < 0)
        {
            Console.Write("Tong điem khong hop le. Nhap lai: ");
        }
        TongDiem = diem;

    }

    public void HienThi()
    {
        Console.WriteLine($"Ho ten: {ChuanHoaTen(HoTen)}, Nam sinh: {NamSinh}, Tong điem: {TongDiem}");
    }

    private string ChuanHoaTen(string ten)
    {
        var textInfo = new CultureInfo("vi-VN", false).TextInfo;
        return textInfo.ToTitleCase(ten.ToLower());
    }
}
