public class ThiSinh
{
    public string SoBaoDanh { get; set; }
    public string HoTen { get; set; }
    public string DiaChi { get; set; }
    public double UuTien { get; set; }

    public ThiSinh() { }

    public ThiSinh(string soBaoDanh, string hoTen, string diaChi, double uuTien)
    {
        SoBaoDanh = soBaoDanh;
        HoTen = hoTen;
        DiaChi = diaChi;
        UuTien = uuTien;
    }

    public virtual double TinhTongDiem()
    {
        return 0;
    }

    public virtual void Nhap()
    {
        Console.Write("Nhap so bao danh: ");
        SoBaoDanh = Console.ReadLine();
        Console.Write("Nhap ho ten: ");
        HoTen = Console.ReadLine();
        Console.Write("Nhap dia chi: ");
        DiaChi = Console.ReadLine();

        while (true)
        {
            Console.Write("Nhap diem uu tien: ");
            if (double.TryParse(Console.ReadLine(), out double diemUuTien))
            {
                UuTien = diemUuTien;
                break;
            }
            else
            {
                Console.WriteLine("Vui long nhap so.");
            }
        }
    }

    public virtual void HienThi()
    {
        Console.WriteLine($"SBD: {SoBaoDanh}, Ho ten: {HoTen}, Dia chi: {DiaChi}, Uu tien: {UuTien}");
    }
}
