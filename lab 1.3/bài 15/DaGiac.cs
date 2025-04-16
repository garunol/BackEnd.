using System;

class DaGiac
{
    protected int soCanh;
    protected int[] kichThuoc;

    public DaGiac() { }

    public DaGiac(int soCanh)
    {
        this.soCanh = soCanh;
        kichThuoc = new int[soCanh];
    }

    public virtual void Nhap()
    {
        Console.Write("Nhập số cạnh: ");
        soCanh = int.Parse(Console.ReadLine());
        kichThuoc = new int[soCanh];

        for (int i = 0; i < soCanh; i++)
        {
            Console.Write($"Nhập độ dài cạnh {i + 1}: ");
            kichThuoc[i] = int.Parse(Console.ReadLine());
        }
    }

    public virtual int TinhChuVi()
    {
        int chuVi = 0;
        for (int i = 0; i < soCanh; i++)
        {
            chuVi += kichThuoc[i];
        }
        return chuVi;
    }

    public virtual void InCanh()
    {
        Console.Write("Các cạnh: ");
        for (int i = 0; i < soCanh; i++)
        {
            Console.Write(kichThuoc[i] + " ");
        }
        Console.WriteLine();
    }

    public int[] LayKichThuoc()
    {
        return kichThuoc;
    }
}
