class Rekening
{
    private string _noRekening;

    private int _saldo;

    public string Norekening
    {
        set 
        {
            _noRekening = value;
        }
    }
    public int Saldo
    {
        get { return _saldo; }
        set
        {
            if (value < 0) Console.WriteLine("Saldo tidak boleh negatif");
            else _saldo = value;
        }
    }
    public Rekening(string no_rekening)
    {
        _noRekening = no_rekening;
    }

    public void DisplayInfo()
    {
        Console.WriteLine("Menampilkan Info...");
        Console.WriteLine($"Saldo saat ini{Saldo} ");
    }
}