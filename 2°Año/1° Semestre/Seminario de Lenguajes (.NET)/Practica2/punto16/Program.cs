// 16) Implementar un programa que muestre todos los números primos entre 1 y un número natural dado (pasado al programa como 
//     argumento por la línea de comandos). Definir el método bool EsPrimo(int n) que devuelve true sólo si n es primo. Esta función 
//     debe comprobar si n es divisible por algún número entero entre 2 y la raíz cuadrada de n. (Nota: Math.Sqrt(d) devuelve la 
//     raíz cuadrada de d)

static bool EsPrimo(int n){
    if(n < 2){
        return false;
    }
    for (int i = 2; i <= Math.Sqrt(n); i++){
        if (n % i == 0)
            return false;
    }
    return true;
}

int n = int.Parse(args[0]);
Console.WriteLine("Numero primos entre 1 y "+n);
for (int i = 1; i <= n; i++){
    if(EsPrimo(i))
        Console.Write(i+"-");
}