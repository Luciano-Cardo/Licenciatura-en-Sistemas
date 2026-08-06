namespace punto2;

public class Cuenta
{
    private double _saldo;
    private int _id;
    private static int ultimoId=0;
    private static int _depositos=0;
    private static double _totalDepositado=0;
    private static int _extracciones=0;
    private static double _totalExtraido=0;
    private static int _denegadas=0;
    private static List<Cuenta> _cuentas = new List<Cuenta>();

    public Cuenta()
    {
        ultimoId++;
        _id = ultimoId;
        _saldo = 0;
        _cuentas.Add(this);
        Console.WriteLine($"Se creo la cuenta {_id}");

    }
    public Cuenta Extraer (double monto)
    {
        if (monto > _saldo)
        {
            Console.WriteLine($"Operación denegada - Saldo insuficiente");
            _denegadas++;
        }
        else
        {
            _saldo -= (double)monto;
            _totalExtraido += monto;
            _extracciones++;
            Console.WriteLine($"Se extrajo {monto} de la cuenta {_id} (Saldo = {_saldo})");
        }
        return this;
    }

    public Cuenta Depositar(double monto)
    {
        _saldo += monto;
        _totalDepositado += monto;
        _depositos++;
        Console.WriteLine($"Se deposito {monto} en la cuenta {_id} (Saldo = {_saldo})");
        return this;
    }

    public static List<Cuenta> GetCuentas()
    {
        return new List<Cuenta>(_cuentas);
    }

    public static void ImprimirDetalle()
    {
        Console.WriteLine($"CUENTAS CREADAS: {ultimoId}");
        Console.WriteLine($"DEPOSITOS:\t {_depositos} \t- Total depositado: {_totalDepositado}");
        Console.WriteLine($"EXTRACCIONES:\t {_extracciones} \t- Total extraido:   {_totalExtraido}");
        Console.WriteLine($"* Se denegaron {_denegadas} extracciones por falta de fondos");
    }
}
