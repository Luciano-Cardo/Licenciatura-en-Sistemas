//8) Investigar sobre el tipo DateTime y usarlo para medir el tiempo de ejecución de los algoritmos implementados en el ejercicio 
//    anterior.

//Medición con String
DateTime inicio1 = DateTime.Now;

string texto = "";
for (int i = 0; i < 10000; i++){
    texto += i;
}

DateTime fin1 = DateTime.Now;
TimeSpan tiempoString = fin1 - inicio1;

Console.WriteLine("Tiempo con string: " + tiempoString.TotalMilliseconds + " ms");

Console.WriteLine("------------------------------------------");

//Medición con StringBuilder
using System.Text;

DateTime inicio2 = DateTime.Now;

StringBuilder sb = new StringBuilder();
for (int i = 0; i < 10000; i++){
    sb.Append(i);
}
string resultado = sb.ToString();

DateTime fin2 = DateTime.Now;
TimeSpan tiempoSB = fin2 - inicio2;

Console.WriteLine("Tiempo con StringBuilder: " + tiempoSB.TotalMilliseconds + " ms");

//El TimeSpan te dice el tiempo que paso entre 2 horarios
//El DateTime.Now te dice la hora exacta