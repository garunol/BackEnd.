using System;
using System.Text.RegularExpressions;

public class VanBan
{
    public string NoiDung { get; set; }

    // Constructor không đối
    public VanBan()
    {
        NoiDung = "";
    }

    // Constructor có đối số
    public VanBan(string st)
    {
        NoiDung = st;
    }

    // Phương thức đếm số từ trong chuỗi
    public int DemSoTu()
    {
        if (string.IsNullOrWhiteSpace(NoiDung))
            return 0;

        string[] tu = NoiDung.Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        return tu.Length;
    }

    // Phương thức đếm số ký tự 'H' hoặc 'h'
    public int DemSoKyTuH()
    {
        int dem = 0;
        foreach (char c in NoiDung)
        {
            if (char.ToUpper(c) == 'H')
            {
                dem++;
            }
        }
        return dem;
    }

    // Phương thức chuẩn hóa chuỗi
    public void ChuanHoaChuoi()
    {
        if (!string.IsNullOrWhiteSpace(NoiDung))
        {
            // Loại bỏ khoảng trắng ở đầu và cuối, thay thế nhiều khoảng trắng liên tiếp bằng 1 dấu cách
            NoiDung = Regex.Replace(NoiDung.Trim(), @"\s+", " ");
        }
    }

    // Hiển thị nội dung chuỗi
    public void HienThi()
    {
        Console.WriteLine("Noi dung van ban: \"" + NoiDung + "\"");
    }
}
