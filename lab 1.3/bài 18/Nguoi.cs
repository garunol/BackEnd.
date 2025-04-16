public class Nguoi
{
    public string HoTen { get; set; }
    public bool GioiTinh { get; set; } // true = Nam, false = Nu
    public int Tuoi { get; set; }

    public Nguoi() { }

    public Nguoi(string hoTen, bool gioiTinh, int tuoi)
    {
        HoTen = hoTen;
        GioiTinh = gioiTinh;
        Tuoi = tuoi;
    }

    public virtual void In()
    {
        Console.WriteLine($"Ho ten: {HoTen}, Gioi tinh: {(GioiTinh ? "Nam" : "Nu")}, Tuoi: {Tuoi}");
    }
}
