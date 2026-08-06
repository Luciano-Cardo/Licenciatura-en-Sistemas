// 18) Cuál es la salida por consola del siguiente programa:
    
    try
    {
        Metodo1();
    }
    catch
    {
        Console.WriteLine("Método 1 propagó una excepción no tratada");
    }
    try
    {
        Metodo2();
    }
    catch
    {
        Console.WriteLine("Método 2 propagó una excepción no tratada");
    }
    try
    {
        Metodo3();
    }
    catch
    {
        Console.WriteLine("Método 3 propagó una excepción");
    }

    void Metodo1()
    {
        object obj = "hola";
        try
        {
            int i = (int)obj;
        }
        finally
        {
            Console.WriteLine("Bloque finally en Metodo1");
        }
    }

    void Metodo2()
    {
        object obj = "hola";
        try
        {
        int i = (int)obj;
        }
        catch (OverflowException)
        {
        Console.WriteLine("Overflow");
        }
    }

    void Metodo3()
    {
        object obj = "hola";
        try
        {
            int i = (int)obj;
        }
        catch (InvalidCastException)
        {
            Console.WriteLine("Excepción InvalidCast en Metodo3");
            throw;
        }
    }

Console.WriteLine("En el Método1 se ejecuta el bloque finally y la excepción se propaga. En el Método2 la excepción no es capturada"+
                  "debido a que el catch espera otro tipo, por lo que también se propaga. En el Método3 la excepción es capturada,"+
                  "se muestra un mensaje y luego se relanza con throw, siendo finalmente capturada en el bloque principal.");