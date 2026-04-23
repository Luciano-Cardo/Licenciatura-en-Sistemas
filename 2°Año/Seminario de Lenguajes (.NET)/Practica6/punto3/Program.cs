// 3) ¿Por qué no funciona el siguiente código? ¿Cómo se puede solucionar fácilmente?

//    class Auto
//     {
//         double velocidad;
//         public virtual void Acelerar() => Console.WriteLine("Velocidad = {0}", velocidad += 10);
//     }
//     class Taxi : Auto
//     {
//         public override void Acelerar() => Console.WriteLine("Velocidad = {0}", velocidad += 5);
//     }

Console.WriteLine("El campo velocidad en Auto es private por defecto y no se puede acceder a velocidad porque las clases derivadas no ven miembros privados de la clase base.");

class Auto
{
    protected double velocidad {get; set;}
    public virtual void Acelerar() => Console.WriteLine("Velocidad = {0}", velocidad += 10);
}
class Taxi : Auto
{
    public override void Acelerar() => Console.WriteLine("Velocidad = {0}", velocidad += 5);
}