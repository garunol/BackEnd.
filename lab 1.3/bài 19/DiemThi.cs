public class DiemThi
{
    public double Toan { get; set; }
    public double Ly { get; set; }
    public double Hoa { get; set; }

    public DiemThi() { }

    public DiemThi(double toan, double ly, double hoa)
    {
        Toan = toan;
        Ly = ly;
        Hoa = hoa;
    }

    public double TongDiem()
    {
        return Toan + Ly + Hoa;
    }
}
