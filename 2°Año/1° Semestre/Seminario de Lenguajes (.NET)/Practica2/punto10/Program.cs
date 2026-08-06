// 10) ¿Para qué sirve el método Split de la clase string? Usarlo para escribir en la consola todas las palabras (una por línea) 
//     de una frase ingresada por consola por el usuario.

Console.WriteLine("El método Split de string sirve para dividir una cadena en partes usando un separador, y devuelve un array de strings.");

Console.WriteLine("Ingresa una frase");
string frase = Console.ReadLine();

string [] palabras = frase.Split(' ');
Console.WriteLine("Palabras: ");

foreach(string palabra in palabras){
    Console.WriteLine(palabra);
}