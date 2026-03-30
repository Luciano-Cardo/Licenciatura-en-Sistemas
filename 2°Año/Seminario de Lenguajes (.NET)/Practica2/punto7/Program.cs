// 7) Investigar acerca de la clase StringBuilder del espacio de nombre System.Text ¿En qué circunstancias es preferible utilizar 
// StringBuilder en lugar de utilizar string? Implementar un caso de ejemplo en el que el rendimiento sea claramente superior 
// utilizando StringBuilder en lugar de string y otro en el que no.

using System.Text;//Lo usamos solo cuando queremos usar StringBuilder

Console.WriteLine("Conviene usar stringBuilder cuando vamos a concatenar string muchas veces(loops, acumuladores), cuando generamos textos grandes y cuando no sabemos el tamaño final");

string texto = "";
StringBuilder sb = new StringBuilder();
for (int i = 0; i < 10000; i++){
    sb.Append(i);
}
texto = sb.ToString();
Console.WriteLine("En este caso es eficiente");

Console.WriteLine("--------------------------------------");

for (int i = 0; i < 10000; i++){
    texto += i;
}
Console.WriteLine("En este caso es ineficiente");