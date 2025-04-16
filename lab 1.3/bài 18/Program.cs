using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<CoQuan> danhSach = new List<CoQuan>();
        int n;
        Console.Write("Nhap so luong ca nhan: ");
        while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
        {
            Console.Write("Vui long nhap so nguyen duong: ");
        }

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\n--- Nhap thong tin ca nhan thu {i + 1} ---");
            Console.Write("Ho ten: ");
            string hoTen = Console.ReadLine();

            Console.Write("Gioi tinh (Nam = true / Nu = false): ");
            bool gioiTinh = bool.Parse(Console.ReadLine());

            Console.Write("Tuoi: ");
            int tuoi = int.Parse(Console.ReadLine());

            Console.Write("Don vi cong tac: ");
            string donVi = Console.ReadLine();

            Console.Write("He so luong: ");
            double heSoLuong = double.Parse(Console.ReadLine());

            danhSach.Add(new CoQuan(hoTen, gioiTinh, tuoi, donVi, heSoLuong));
        }

        int luaChon;
        do
        {
            Console.WriteLine("\n========== MENU ==========");
            Console.WriteLine("1. Hien thi ca nhan thuoc don vi 'Phong tai chinh'");
            Console.WriteLine("2. Tim kiem theo ho ten");
            Console.WriteLine("3. Thoat");
            Console.Write("Nhap lua chon: ");
            luaChon = int.Parse(Console.ReadLine());

            switch (luaChon)
            {
                case 1:
                    Console.WriteLine("\n--- Danh sach ca nhan thuoc Phong tai chinh ---");
                    var taiChinh = danhSach.Where(c => c.DonVi.ToLower() == "phong tai chinh").ToList();
                    if (taiChinh.Count == 0)
                        Console.WriteLine("Khong co ai thuoc Phong tai chinh.");
                    else
                        taiChinh.ForEach(c => c.In());
                    break;

                case 2:
                    Console.Write("Nhap ho ten can tim: ");
                    string hoTenTim = Console.ReadLine().ToLower();
                    var ketQua = danhSach.Where(c => c.HoTen.ToLower().Contains(hoTenTim)).ToList();
                    if (ketQua.Count == 0)
                        Console.WriteLine("Khong tim thay ca nhan nao.");
                    else
                        ketQua.ForEach(c => c.In());
                    break;

                case 3:
                    Console.WriteLine("Thoat chuong trinh.");
                    break;

                default:
                    Console.WriteLine("Lua chon khong hop le!");
                    break;
            }

        } while (luaChon != 3);
    }
}
