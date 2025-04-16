public class QueQuan
{
    public string Xa { get; set; }
    public string Huyen { get; set; }
    public string Tinh { get; set; }

    public QueQuan() { }

    public QueQuan(string xa, string huyen, string tinh)
    {
        Xa = xa;
        Huyen = huyen;
        Tinh = tinh;
    }

    public override string ToString()
    {
        return $"{Xa}, {Huyen}, {Tinh}";
    }
}
