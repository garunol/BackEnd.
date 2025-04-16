using System;

public class MaTran
{
    private int[,] duLieu;
    public int SoDong { get; set; }
    public int SoCot { get; set; }

    // Hàm tạo không đối số
    public MaTran()
    {
        SoDong = 0;
        SoCot = 0;
        duLieu = new int[0, 0];
    }

    // Hàm tạo có đối số
    public MaTran(int n, int m)
    {
        SoDong = n;
        SoCot = m;
        duLieu = new int[n, m];
    }

    // Nhập ma trận
    public void Nhap()
    {
        Console.Write("Nhap so dong: ");
        SoDong = int.Parse(Console.ReadLine());
        Console.Write("Nhap so cot: ");
        SoCot = int.Parse(Console.ReadLine());

        duLieu = new int[SoDong, SoCot];

        for (int i = 0; i < SoDong; i++)
        {
            for (int j = 0; j < SoCot; j++)
            {
                Console.Write($"Nhap [{i},{j}]: ");
                duLieu[i, j] = int.Parse(Console.ReadLine());
            }
        }
    }

    // Hiển thị ma trận
    public void HienThi()
    {
        for (int i = 0; i < SoDong; i++)
        {
            for (int j = 0; j < SoCot; j++)
            {
                Console.Write(duLieu[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    // Tính tổng 2 ma trận
    public MaTran Cong(MaTran b)
    {
        if (SoDong != b.SoDong || SoCot != b.SoCot)
            throw new Exception("Hai ma tran khong cung kich thuoc!");

        MaTran kq = new MaTran(SoDong, SoCot);
        for (int i = 0; i < SoDong; i++)
        {
            for (int j = 0; j < SoCot; j++)
            {
                kq.duLieu[i, j] = duLieu[i, j] + b.duLieu[i, j];
            }
        }
        return kq;
    }

    // Tính hiệu 2 ma trận
    public MaTran Tru(MaTran b)
    {
        if (SoDong != b.SoDong || SoCot != b.SoCot)
            throw new Exception("Hai ma tran khong cung kich thuoc!");

        MaTran kq = new MaTran(SoDong, SoCot);
        for (int i = 0; i < SoDong; i++)
        {
            for (int j = 0; j < SoCot; j++)
            {
                kq.duLieu[i, j] = duLieu[i, j] - b.duLieu[i, j];
            }
        }
        return kq;
    }

    // Tính tích 2 ma trận
    public MaTran Nhan(MaTran b)
    {
        if (SoCot != b.SoDong)
            throw new Exception("So cot ma tran A phai bang so dong ma tran B de nhan!");

        MaTran kq = new MaTran(SoDong, b.SoCot);
        for (int i = 0; i < SoDong; i++)
        {
            for (int j = 0; j < b.SoCot; j++)
            {
                for (int k = 0; k < SoCot; k++)
                {
                    kq.duLieu[i, j] += duLieu[i, k] * b.duLieu[k, j];
                }
            }
        }
        return kq;
    }

    // Giả lập phép chia từng phần tử (nếu muốn chia từng phần tử A / B)
    public MaTran Chia(MaTran b)
    {
        if (SoDong != b.SoDong || SoCot != b.SoCot)
            throw new Exception("Hai ma tran khong cung kich thuoc!");

        MaTran kq = new MaTran(SoDong, SoCot);
        for (int i = 0; i < SoDong; i++)
        {
            for (int j = 0; j < SoCot; j++)
            {
                if (b.duLieu[i, j] == 0)
                    throw new DivideByZeroException($"Phan tu tai [{i},{j}] cua ma tran B bang 0.");
                kq.duLieu[i, j] = duLieu[i, j] / b.duLieu[i, j];
            }
        }
        return kq;
    }
}
