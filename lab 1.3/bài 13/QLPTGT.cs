public class QLPTGT
{
    private List<PTGT> danhSach = new List<PTGT>();

    public void NhapPhuongTien()
    {
        Console.WriteLine("1. O To\n2. Xe May\n3. Xe Tai");
        Console.Write("Chon loai phuong tien: ");
        int loai = int.Parse(Console.ReadLine());
        PTGT pt;

        switch (loai)
        {
            case 1: pt = new OTo(); break;
            case 2: pt = new XeMay(); break;
            case 3: pt = new XeTai(); break;
            default: Console.WriteLine("Lua chon sai!"); return;
        }

        pt.Nhap();
        danhSach.Add(pt);
    }

    public void TimTheoMauHoacNam()
    {
        Console.WriteLine("1. Tim theo mau\n2. Tim theo nam san xuat");
        Console.Write("Chon: ");
        int chon = int.Parse(Console.ReadLine());

        if (chon == 1)
        {
            Console.Write("Nhap mau can tim: ");
            string mau = Console.ReadLine();
            foreach (var pt in danhSach.Where(x => x.Mau.ToLower() == mau.ToLower()))
                pt.HienThi();
        }
        else if (chon == 2)
        {
            Console.Write("Nhap nam can tim: ");
            int nam = int.Parse(Console.ReadLine());
            foreach (var pt in danhSach.Where(x => x.NamSanXuat == nam))
                pt.HienThi();
        }
    }

    public void HienThiTatCa()
    {
        foreach (var pt in danhSach)
        {
            pt.HienThi();
            Console.WriteLine("-------------------");
        }
    }
}
