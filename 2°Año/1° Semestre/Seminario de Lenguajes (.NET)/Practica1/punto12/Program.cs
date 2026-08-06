// 12) Escribir un programa que imprima todos los divisores de un número entero ingresado desde la
//     consola. Para obtener el entero desde un string st utilizar int.Parse(st).

Console.WriteLine("Ingrese un numero");
string st = Console.ReadLine();
int nro = int.Parse(st);
for (int i = 1; i <= nro; i++){     
    if(nro % i == 0){
        Console.WriteLine(i);
    }
}