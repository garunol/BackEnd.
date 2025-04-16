public class TuyenSinh
{
    private List<ThiSinh> danhSach = new List<ThiSinh>();

    public void NhapThiSinh()
    {
        Console.Write("Nhap loai thi sinh (A/B/C): ");
        string loai = Console.ReadLine().ToUpper();

        ThiSinh ts = null;
        switch (loai)
        {
            case "A":
                ts = new ThiSinhKhoiA();
                break;
            case "B":
                ts = new ThiSinhKhoiB();
                break;
            case "C":
                ts = new ThiSinhKhoiC();
                break;
            default:
                Console.WriteLine("Khong hop le.");
                return;
        }

        ts.Nhap();
        danhSach.Add(ts);
    }

    public void HienThiTrungTuyen()
    {
        Console.WriteLine("Danh sach trung tuyen:");
        foreach (var ts in danhSach)
        {
            double diemChuan = 0;
            if (ts is ThiSinhKhoiA) diemChuan = 15;
            else if (ts is ThiSinhKhoiB) diemChuan = 16;
            else if (ts is ThiSinhKhoiC) diemChuan = 13.5;

            if (ts.TinhTongDiem() >= diemChuan)
            {
                ts.HienThi();
                Console.WriteLine();
            }
        }
    }

    public void TimTheoSoBaoDanh()
    {
        Console.Write("Nhap so bao danh can tim: ");
        string sbd = Console.ReadLine();

        foreach (var ts in danhSach)
        {
            if (ts.SoBaoDanh == sbd)
            {
                ts.HienThi();
                return;
            }
        }
        Console.WriteLine("Khong tim thay.");
    }
}
