// 14) Utilizar el operador ternario condicional para establecer el contenido de una variable entera con el menor valor de otras 
//     dos variables enteras.

int valor1;
Console.WriteLine("Ingrese un valor");
int valor2 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese otro valor");
int valor3 = int.Parse(Console.ReadLine());

int menor = valor2 > valor3? valor1=valor3 : valor1=valor2;

Console.WriteLine("--------------------");
Console.WriteLine("valor 1: "+valor1);
Console.WriteLine("valor 2: "+valor2);
Console.WriteLine("valor 3: "+valor3);