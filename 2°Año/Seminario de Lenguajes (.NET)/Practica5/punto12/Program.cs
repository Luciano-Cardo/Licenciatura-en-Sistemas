// 12) Se solicita modelar una clase Libro para un sistema de inventario. El sistema debe ser muy estricto con la integridad de los 
//     datos. La clase debe cumplir con los siguientes requisitos de encapsulamiento: 
//     ISBN (Solo lectura): Su valor solo debe  asignarse a través del constructor. Una vez creado el objeto, no podrá ser reasignado
//     bajo ninguna circunstancia.
//     FechaPublicacion: Debe permitir su asignación al momento de crear el objeto (usando inicializadores), pero una vez finalizada 
//     la construcción, no podrá ser reasignada. Debe permitir valores nulos si no se conoce la fecha.
//     Titulo: Es obligatorio proporcionar un título al instanciar el libro (vía inicializador) y este no podrá volver a asignarse 
//     después.
//     Precio: Debe permitir su lectura y modificación en cualquier momento del ciclo de vida del objeto.
//     Prueba de compilación: En el Program.cs, verificar los siguientes casos, todos salvo el caso C deberían presentar problemas 
//     para compilar.

//     // Caso A:
//     Libro libro1 = new Libro();
//     // Caso B:
//     Libro libro2 = new Libro
//     {
//     Titulo = "C# Moderno",
//     FechaPublicacion = new DateTime(2026, 1, 1),
//     Precio = 4500.0,
//     ISBN = "978-3-16-148410-0"
//     };
//     // Caso C:
//     Libro libro3 = new Libro("978-3-16-148410-0") {Titulo="C# Moderno"};
//     libro3.Precio=4500.0;
//     // Caso D:
//     libro3.ISBN = "978-3-16-148410-9";
//     libro3.FechaPublicacion = DateTime.Now;
//     libro3.Titulo=".NET Moderno";

using punto12;
// Caso A:
Libro libro1 = new Libro(); //falta el constructor con ISBN
// Caso B:
Libro libro2 = new Libro
{
    Titulo = "C# Moderno",
    FechaPublicacion = new DateTime(2026, 1, 1),
    Precio = 4500.0,
    ISBN = "978-3-16-148410-0" //ISBN no tiene setter
};
// Caso C:
Libro libro3 = new Libro("978-3-16-148410-0") {Titulo="C# Moderno"};
libro3.Precio=4500.0;
// Caso D:
libro3.ISBN = "978-3-16-148410-9"; //ISBN no tiene setter
libro3.FechaPublicacion = DateTime.Now; //init only
libro3.Titulo=".NET Moderno"; //init only

Console.WriteLine("El unico caso valido es el C");