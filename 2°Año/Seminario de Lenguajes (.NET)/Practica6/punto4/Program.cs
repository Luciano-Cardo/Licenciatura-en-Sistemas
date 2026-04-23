// 4) Contestar sobre el siguiente programa:

//    Taxi t = new Taxi(3);
//     Console.WriteLine($"Un {t.Marca} con {t.Pasajeros} pasajeros");
//     class Auto
//     {
//         public string Marca { get; private set; } = "Ford";
//         public Auto(string marca) => this.Marca = marca;
//         public Auto() { }
//     }
//     class Taxi : Auto
//     {
//         public int Pasajeros { get; private set; }
//         public Taxi(int pasajeros) => this.Pasajeros = pasajeros;
//     }

//     ¿Por qué no es necesario agregar :base en el constructor de Taxi? Eliminar el segundo constructor de la clase Auto y modificar la clase 
//     Taxi para el programa siga funcionando.

Console.WriteLine("No es necesario agregar :base en el constructor de taxi porque en la clase Auto existe el constructor vacio");

Taxi t = new Taxi(3);
Console.WriteLine($"Un {t.Marca} con {t.Pasajeros} pasajeros");
class Auto
{
    public string Marca { get; private set; } = "Ford";
    public Auto(string marca) => this.Marca = marca;
}
class Taxi : Auto
{
    public int Pasajeros { get; private set; }
    public Taxi(int pasajeros) :base("Ford")
    {
        this.Pasajeros = pasajeros;
    }
}