// 5) Agregar un segundo constructor a la clase Hora para que pueda especificarse la hora por medio de
//    un único valor que admita decimales. Por ejemplo 3,5 indica la hora 3 y 30 minutos. Si se utiliza este
//    segundo constructor, el método imprimir debe mostrar los segundos con tres dígitos decimales. Así el
//    siguiente código debe producir la salida por consola que se observa.

//    new Hora(23, 30, 15).Imprimir();
//    new Hora(14.43).Imprimir();
//    new Hora(14.45).Imprimir();
//    new Hora(14.45114).Imprimir();

namespace punto5 
{
    class Program
    {
        static void Main(string[] args)
        {
            new Hora(23, 30, 15).Imprimir();
            new Hora(14.43).Imprimir();
            new Hora(14.45).Imprimir();
            new Hora(14.45114).Imprimir();
        }
    }
}