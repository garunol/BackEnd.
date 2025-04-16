using System;

public class SinhVien : Nguoi
{
    public string Lop { get; set; }
    public double DiemTB { get; set; }

    public override void Nhap()
    {
        base.Nhap();
        Console.Write("Lop: ");
        Lop = Console.ReadLine();

        Console.Write("Diem trung binh: ");
        DiemTB = double.Parse(Console.ReadLine());
    }

    public override void HienThi()
    {
        base.HienThi();
        Console.WriteLine($"Lop: {Lop}, Diem TB: {DiemTB}");
    }
}
