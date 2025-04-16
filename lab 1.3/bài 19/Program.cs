using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<ThiSinh> danhSach = new List<ThiSinh>();

        Console.Write("Nhap so luong thi sinh: ");
        int n;
        while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
        {
            Console.Write("Vui long nhap so nguyen duong: ");
        }

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\n--- Nhap thong tin thi sinh thu {i + 1} ---");

            Console.Write("Ho: ");
            string ho = Console.ReadLine();
            Console.Write("Ten dem: ");
            string dem = Console.ReadLine();
            Console.Write("Ten: ");
            string ten = Console.ReadLine();
            var hoTen = new HoTen(ho, dem, ten);

            Console.Write("Xa: ");
            string xa = Console.ReadLine();
            Console.Write("Huyen: ");
            string huyen = Console.ReadLine();
            Console.Write("Tinh: ");
            string tinh = Console.ReadLine();
            var queQuan = new QueQuan(xa, huyen, tinh);

            Console.Write("Truong: ");
            string truong = Console.ReadLine();
            Console.Write("Tuoi: ");
            int tuoi = int.Parse(Console.ReadLine());
            Console.Write("So bao danh: ");
            string sbd = Console.ReadLine();

            Console.Write("Diem Toan: ");
            double toan = double.Parse(Console.ReadLine());
            Console.Write("Diem Ly: ");
            double ly = double.Parse(Console.ReadLine());
            Console.Write("Diem Hoa: ");
            double hoa = double.Parse(Console.ReadLine());
            var diem = new DiemThi(toan, ly, hoa);

            danhSach.Add(new ThiSinh(hoTen, queQuan, truong, tuoi, sbd, diem));
        }

        Console.WriteLine("\n--- Danh sach thi sinh co tong diem > 15 ---");
        var thiSinhDiemCao = danhSach.Where(ts => ts.Diem.TongDiem() > 15).ToList();
        if (thiSinhDiemCao.Count == 0)
            Console.WriteLine("Khong co thi sinh nao co tong diem > 15.");
        else
        {
            Console.WriteLine($"{"Ho ten",-25} | {"Que quan",-30} | {"SBD",-10} | {"Toan",5} | {"Ly",5} | {"Hoa",5}");
            thiSinhDiemCao.ForEach(ts => ts.InThongTin());
        }

        Console.WriteLine("\n--- Danh sach sap xep theo tong diem giam dan ---");
        var sapXep = danhSach.OrderByDescending(ts => ts.Diem.TongDiem()).ToList();
        Console.WriteLine($"{"Ho ten",-25} | {"Que quan",-30} | {"SBD",-10} | {"Toan",5} | {"Ly",5} | {"Hoa",5}");
        sapXep.ForEach(ts => ts.InThongTin());
    }
}
