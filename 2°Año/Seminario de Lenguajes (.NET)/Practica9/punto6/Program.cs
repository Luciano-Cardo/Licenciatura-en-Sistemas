// 6)  Codificar los métodos de extensión Donde y Seleccionar para todas las clases que implementen la interfaz IEnumerable<T>, que 
//     permite código como el siguiente:

//     int[] vector = [1, 2, 3, 4, 5];
//     vector.Donde(i => i > 3) // IEnumerable<int> : 4, 5
//         .Seleccionar(i => i * 10) // IEnumerable<int> : 40, 50
//         .Seleccionar(i => $"({i})") // IEnumerable<string> : "(40)", "(50)"
//         .ForEach(st => Console.WriteLine(st));

//     Salida por consola
//     (40)
//     (50)

//     Para ello seguir completando la clase estática Extensiones del ejercicio anterior
//     public static class Extensiones
//     {
//         public static void ForEach<T>(this IEnumerable<T> secuencia, . . .
//         public static IEnumerable<T> Donde<T>(this IEnumerable<T> secuencia, . . .
//         public static IEnumerable<TResult> Seleccionar<T, TResult>(this IEnumerable<T> secuencia, . . .
//         . . .

public static class Extensiones
{
    public static void ForEach<T>(this IEnumerable<T> secuencia, Action<T> accion)
    {
        foreach (T elemento in secuencia)
        {
            accion(elemento);
        }
    }
    public static IEnumerable<T> Donde<T>(this IEnumerable<T> secuencia,Func<T, bool> condicion)
    {
        foreach (T elemento in secuencia)
        {
            if (condicion(elemento))
            {
                yield return elemento;
            }
        }
    }
    public static IEnumerable<TResult> Seleccionar<T, TResult>(this IEnumerable<T> secuencia,Func<T, TResult> selector)
    {
        foreach (T elemento in secuencia)
        {
            yield return selector(elemento);
        }
    }
}
class Program
{
    static void Main()
    {
        int[] vector = { 1, 2, 3, 4, 5 };
        vector.Donde(i => i > 3).Seleccionar(i => i * 10).Seleccionar(i => $"({i})").ForEach(st => Console.WriteLine(st));
    }
}