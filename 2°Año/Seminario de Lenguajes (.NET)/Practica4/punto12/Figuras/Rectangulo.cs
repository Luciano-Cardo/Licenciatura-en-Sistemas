namespace Figuras;

public class Rectangulo
{
    private double _altura;
    private double _base;

    public Rectangulo(double altura, double base1)
    {
        _altura=altura;
        _base=base1;
    }

    public double GetArea()
    {
        return _altura*_base;
    }
}
