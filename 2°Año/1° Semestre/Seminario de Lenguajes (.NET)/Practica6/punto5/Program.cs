// 5) ¿Qué líneas del siguiente código provocan error de compilación y por qué?

//     class Persona
//     {
//         public string Nombre { get; set; }
//     }
//     public class Auto
//     {
//         private Persona _dueño1, _dueño2;
//         public Persona GetPrimerDueño() => _dueño1;
//         protected Persona SegundoDueño
//         {
//         set => _dueño2 = value;
//         }
//     }

Console.WriteLine("El código compila correctamente, pero la propiedad SegundoDueño solo puede ser utilizada para asignación y únicamente desde clases derivadas, lo cual limita su uso.");

