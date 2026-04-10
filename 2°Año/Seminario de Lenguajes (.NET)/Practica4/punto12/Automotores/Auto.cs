namespace Automotores;

public class Auto
{
    private string _marca;
    private int _modelo;

    public Auto()
    {
        _marca="Fiat";
        _modelo=DateTime.Now.Year;
    }
    public Auto(string marca, int modelo): this()
    {
        _marca = marca;
        _modelo = modelo;
    }
    public Auto(string marca)
    {
        _marca=marca;
    }
    public string GetDescripcion() =>
        $"Auto {_marca} {_modelo}";
}

