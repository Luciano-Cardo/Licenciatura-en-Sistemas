// 1) Utilizando el método Range de la clase System.Linq.Enumerable y los métodos de LINQ que sean necesarios, obtener:
//     a) Lista con todos los múltiplos de 5 entre 100 y 200
//     b) Lista con todos los números primos menores que 100
//     c) Lista con las potencias de 2, desde 20 a 210
//     d) La suma y el promedio de los valores de la lista anterior
//     e) Lista de todos los n2 que terminan con el dígito 6, para n entre 1 y 20
//     f) Lista con los nombres de los días de la semana en inglés que contengan una letra ‘u’
//     (tip: utilizar el enumerativo DayOfWeek)

using System.Linq;

class Program
{
    static void Main()
    {
        var multiplosDe5 = Enumerable.Range(100, 101)
                                     .Where(n => n % 5 == 0);
        Console.WriteLine(string.Join(", ", multiplosDe5));

        var primos = Enumerable.Range(2, 98)
                               .Where(n => Enumerable.Range(2, (int)Math.Sqrt(n) - 1)
                               .All(d => n % d != 0));
        Console.WriteLine(string.Join(", ", primos));

        var potenciasDe2 = Enumerable.Range(0, 11)
                                     .Select(n => (long)Math.Pow(2, n));
        Console.WriteLine(string.Join(", ", potenciasDe2));

        var suma = potenciasDe2.Sum();
        var promedio = potenciasDe2.Average();
        Console.WriteLine(suma);
        Console.WriteLine(promedio);

        var cuadradosTerminadosEn6 = Enumerable.Range(1, 20)
                                               .Select(n => n * n)
                                               .Where(c => c % 10 == 6);
        Console.WriteLine(string.Join(", ", cuadradosTerminadosEn6));

        var diasConU = Enum.GetValues(typeof(DayOfWeek))
                           .Cast<DayOfWeek>()
                           .Select(d => d.ToString())
                           .Where(nombre => nombre.Contains('u'));
        Console.WriteLine(string.Join(", ", diasConU));
    }
}