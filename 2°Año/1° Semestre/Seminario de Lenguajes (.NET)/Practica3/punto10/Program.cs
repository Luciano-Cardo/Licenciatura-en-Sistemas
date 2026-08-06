// 10) Verificar con un par de ejemplos si la sección opcional [:formatString] de formatos  compuestos redondea o trunca cuando se 
//     formatean números reales restringiendo la cantidad de decimales. Plantear los ejemplos con cadenas de formato compuesto y 
//     con cadenas interpoladas.

double n1 = 3.14159;
double n2 = 3.145;

Console.WriteLine("CON FORMATO COMPUESTO");
Console.WriteLine("Formato 0.00 → {0:0.00}", n1);
Console.WriteLine("Formato 0.00 → {0:0.00}", n2);
Console.WriteLine("CON CADENAS INTERPOLADAS");
Console.WriteLine($"Formato 0.00 → {n1:0.00}");
Console.WriteLine($"Formato 0.00 → {n2:0.00}");