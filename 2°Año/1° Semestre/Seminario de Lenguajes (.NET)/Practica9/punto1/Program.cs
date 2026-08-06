// 1)  Codificar el método genérico Get para que el siguiente código produzca la salida en la consola indicada.

//     List<object> lista = [ "hola", 7, 'A' ];
//     string st = Get<string>(lista, 0);
//     int i = Get<int>(lista, 1);
//     char c = Get<char>(lista, 2);
//     Console.WriteLine($"{st} {i} {c}");

//     Salida por consola
//     hola 7 A

class Program
{
    public static T Get<T>(List<object> lista, int indice)
    {
        return (T)lista[indice];
    }

    static void Main()
    {
        List<object> lista = new List<object> { "hola", 7, 'A' };
        string st = Get<string>(lista, 0);
        int i = Get<int>(lista, 1);
        char c = Get<char>(lista, 2);
        Console.WriteLine($"{st} {i} {c}");
    }
}