// 10) Completar la clase Cuenta para que el siguiente código produzca la salida indicada:

//     Cuenta cuenta = new Cuenta();
//     cuenta.Imprimir();
//     cuenta = new Cuenta(30222111);
//     cuenta.Imprimir();
//     cuenta = new Cuenta("José Perez");
//     cuenta.Imprimir();
//     cuenta = new Cuenta("Maria Diaz", 20287544);
//     cuenta.Imprimir();
//     cuenta.Depositar(200);
//     cuenta.Imprimir();
//     cuenta.Extraer(150);
//     cuenta.Imprimir();
//     cuenta.Extraer(1500);

//     class Cuenta
//     {
//         private double _monto;
//         private int _titularDNI;
//         private string? _titularNobre;
//         . . .
//     }

//     //Salida
//     Nombre: No especificado, DNI: No especificado, Monto: 0
//     Nombre: No especificado, DNI: 30222111, Monto: 0
//     Nombre: José Perez, DNI: No especificado, Monto: 0
//     Nombre: Maria Diaz, DNI: 20287544, Monto: 0
//     Nombre: Maria Diaz, DNI: 20287544, Monto: 200
//     Nombre: Maria Diaz, DNI: 20287544, Monto: 50
//     Operación cancelada, monto insuficiente

namespace punto10
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuenta cuenta = new Cuenta();
            cuenta.Imprimir();
            cuenta = new Cuenta(30222111);
            cuenta.Imprimir();
            cuenta = new Cuenta("José Perez");
            cuenta.Imprimir();
            cuenta = new Cuenta("Maria Diaz", 20287544);
            cuenta.Imprimir();
            cuenta.Depositar(200);
            cuenta.Imprimir();
            cuenta.Extraer(150);
            cuenta.Imprimir();
            cuenta.Extraer(1500);
        }
    }
}