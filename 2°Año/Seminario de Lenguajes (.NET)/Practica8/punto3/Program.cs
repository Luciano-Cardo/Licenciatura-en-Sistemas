// 3)  Analizar el siguiente código

//     -------Program.cs---------
//     ContadorDeLineas contador = new ContadorDeLineas();
//     contador.Contar();
//     -------ContadorDeLineas.cs---------
//     class ContadorDeLineas
//     {
//      private int _cantLineas = 0;
//      public void Contar()
//      {
//          Ingresador _ingresador = new Ingresador();
//          _ingresador.Contador = this;
//           _ingresador.Ingresar();
//          Console.WriteLine($"Cantidad de líneas ingresadas: {_cantLineas}");
//      }
//      public void UnaLineaMas() => _cantLineas++;
//     }
//     -------Ingresador.cs---------
//     class Ingresador
//     {
//      public ContadorDeLineas? Contador { get; set; }
//      public void Ingresar()
//      {
//          string st = Console.ReadLine()??"";
//          while (st != "")
//          {
//              Contador?.UnaLineaMas();
//              st = Console.ReadLine()??"";
//          }    
//      }
//     }

//     Existe un alto nivel de acoplamiento entre las clases ContadorDeLineas e Ingresador, habiendo una referencia circular: un objeto ContadorDeLineas
//     posee una referencia a un objeto Ingresador y éste último posee una referencia al primero. Esto no es deseable, hace que el código sea difícil de 
//     mantener. Eliminar esta referencia circular utilizando un evento, de tal forma que ContadorDeLineas posea una referencia a Ingresador pero que no 
//     ocurra lo contrario.

// -------ContadorDeLineas.cs---------
class ContadorDeLineas
{
    private int _cantLineas = 0;
    public void Contar()
    {
        Ingresador ingresador = new Ingresador();
        ingresador.LineaIngresada += UnaLineaMas;
        ingresador.Ingresar();
        Console.WriteLine($"Cantidad de líneas ingresadas: {_cantLineas}");
    }
    public void UnaLineaMas()
    {
        _cantLineas++;
    }
}

// -------Ingresador.cs---------
class Ingresador
{
    public event Action? LineaIngresada;

    public void Ingresar()
    {
        string st = Console.ReadLine() ?? "";
        while (st != "")
        {
            LineaIngresada?.Invoke();
            st = Console.ReadLine() ?? "";
        }
    }
}