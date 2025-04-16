public class ThiSinh
{
    public HoTen HoTen { get; set; }
    public QueQuan QueQuan { get; set; }
    public string Truong { get; set; }
    public int Tuoi { get; set; }
    public string SoBaoDanh { get; set; }
    public DiemThi Diem { get; set; }

    public ThiSinh() { }

    public ThiSinh(HoTen hoTen, QueQuan queQuan, string truong, int tuoi, string soBaoDanh, DiemThi diem)
    {
        HoTen = hoTen;
        QueQuan = queQuan;
        Truong = truong;
        Tuoi = tuoi;
        SoBaoDanh = soBaoDanh;
        Diem = diem;
    }

    public void InThongTin()
    {
        Console.WriteLine($"{HoTen,-25} | {QueQuan,-30} | {SoBaoDanh,-10} | {Diem.Toan,5:F2} | {Diem.Ly,5:F2} | {Diem.Hoa,5:F2} | Tong: {Diem.TongDiem(),5:F2}");
    }
}
