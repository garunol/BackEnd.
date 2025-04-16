public class HoTen
{
    public string Ho { get; set; }
    public string Dem { get; set; }
    public string Ten { get; set; }

    public HoTen() { }

    public HoTen(string ho, string dem, string ten)
    {
        Ho = ho;
        Dem = dem;
        Ten = ten;
    }

    public override string ToString()
    {
        return $"{Ho} {Dem} {Ten}";
    }
}
