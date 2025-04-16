using System;

class Diem
{
    public double x, y;

    public Diem() { }

    public Diem(double x, double y)
    {
        this.x = x;
        this.y = y;
    }

    public void Nhap()
    {
        Console.Write("Nhập hoành độ x: ");
        x = double.Parse(Console.ReadLine());
        Console.Write("Nhập tung độ y: ");
        y = double.Parse(Console.ReadLine());
    }

    public void HienThi()
    {
        Console.Write($"({x}, {y})");
    }

    public double TinhKhoangCach(Diem d2)
    {
        return Math.Sqrt(Math.Pow(d2.x - x, 2) + Math.Pow(d2.y - y, 2));
    }
}
