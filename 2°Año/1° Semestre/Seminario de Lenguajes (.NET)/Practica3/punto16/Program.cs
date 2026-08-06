// 16) ¿Qué salida por la consola produce el siguiente código?

//     int x = 0;
//     try
//     {
//     Console.WriteLine(1.0 / x);
//     Console.WriteLine(1 / x);
//     Console.WriteLine("todo OK");
//     }
//     catch (Exception e)
//     {
//     Console.WriteLine(e.Message);
//     }

//     ¿Qué se puede inferir respecto de la excepción división por cero en relación al tipo de los operandos?


int x = 0;
try
{
    Console.WriteLine(1.0 / x);
    Console.WriteLine(1 / x);
    Console.WriteLine("todo OK");
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

Console.WriteLine("Lanza un exvepcion ya que no se puede dividir por cero(∞,Attempted to divide by zero)");