public class Nguoi
{
    public string HoTen { get; set; }
    public int Tuoi { get; set; }
    public int NamSinh { get; set; }
    public string QueQuan { get; set; }
    public string GioiTinh { get; set; }

    public void Nhap()
    {
        Console.Write("Nhap ho ten: ");
        HoTen = Console.ReadLine();

        Console.Write("Nhap tuoi: ");
        Tuoi = int.Parse(Console.ReadLine());

        Console.Write("Nhap nam sinh: ");
        NamSinh = int.Parse(Console.ReadLine());

        Console.Write("Nhap que quan: ");
        QueQuan = Console.ReadLine();

        Console.Write("Nhap gioi tinh (Nam/Nu): ");
        GioiTinh = Console.ReadLine();
    }

    public void HienThi()
    {
        Console.WriteLine($"Ho ten: {HoTen}, Tuoi: {Tuoi}, Nam sinh: {NamSinh}, Que quan: {QueQuan}, Gioi tinh: {GioiTinh}");
    }
}
