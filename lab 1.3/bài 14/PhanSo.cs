using System;

class PhanSo
{
    public int TuSo { get; set; }
    public int MauSo { get; set; }

    // Hàm tạo không đối
    public PhanSo()
    {
        TuSo = 0;
        MauSo = 1;
    }

    // Hàm tạo có đối số
    public PhanSo(int tu, int mau)
    {
        TuSo = tu;
        MauSo = (mau == 0) ? 1 : mau; // tránh chia cho 0
    }

    // Nhập phân số
    public void Nhap()
    {
        Console.Write("Nhập tử số: ");
        TuSo = int.Parse(Console.ReadLine());
        Console.Write("Nhập mẫu số: ");
        MauSo = int.Parse(Console.ReadLine());
        if (MauSo == 0)
        {
            Console.WriteLine("Mẫu số không được bằng 0. Đặt lại mẫu số = 1.");
            MauSo = 1;
        }
    }

    // Hiển thị phân số
    public void HienThi()
    {
        Console.WriteLine($"{TuSo}/{MauSo}");
    }

    // Tìm ƯCLN
    private int UCLN(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return Math.Abs(a);
    }

    // Rút gọn phân số
    public void RutGon()
    {
        int ucln = UCLN(TuSo, MauSo);
        TuSo /= ucln;
        MauSo /= ucln;

        // Nếu mẫu số âm, chuyển dấu sang tử
        if (MauSo < 0)
        {
            TuSo = -TuSo;
            MauSo = -MauSo;
        }
    }

    // Cộng
    public PhanSo Cong(PhanSo b)
    {
        return new PhanSo(TuSo * b.MauSo + MauSo * b.TuSo, MauSo * b.MauSo);
    }

    // Trừ
    public PhanSo Tru(PhanSo b)
    {
        return new PhanSo(TuSo * b.MauSo - MauSo * b.TuSo, MauSo * b.MauSo);
    }

    // Nhân
    public PhanSo Nhan(PhanSo b)
    {
        return new PhanSo(TuSo * b.TuSo, MauSo * b.MauSo);
    }

    // Chia
    public PhanSo Chia(PhanSo b)
    {
        return new PhanSo(TuSo * b.MauSo, MauSo * b.TuSo);
    }
}
