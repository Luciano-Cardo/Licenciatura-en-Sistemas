// 14) Utilizar la clase Queue<T> para implementar un programa que realice el cifrado de un texto aplicando la técnica de clave 
//     repetitiva. La técnica de clave repetitiva consiste en desplazar un carácter una cantidad constante de acuerdo a la lista de 
//     valores que se encuentra en la clave. Por ejemplo: para la siguiente tabla de caracteres:

//     A B C D E F G H I  J K  L  M  N  Ñ  O  P  Q  R  S  T  U  V  W  X  Y  Z  sp
//     1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20 21 22 23 24 25 26 27 28

//     Si la clave es 5,3,9,7 y el mensaje a cifrar es “HOLA MUNDO”, se cifra de la siguiente manera:

//     H  O  L  A sp M  U  N  D O ← Mensaje original
//     8  16 12 1 28 13 22 14 4 16 ← Código sin cifrar
//     5  3  9  7 5  3  9  7  5 3 ← Clave repetida
//     13 19 21 8 5  16 3  21 9 19 ← Código cifrado
//     M  R  T  H E  O  C  T  I R ← Mensaje cifrado

//     A cada carácter del mensaje original se le suma la cantidad indicada en la clave. En el caso que la suma fuese mayor que 28 
//     se debe volver a contar desde el principio, Implementar una cola con los números de la clave encolados y a medida que se 
//     desencolen para utilizarlos en el cifrado, se vuelvan a encolar para su posterior utilización. Programar un método para cifrar
//     y otro para descifrar.

int CharANum(char c)
{
    string tabla = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ ";
    return tabla.IndexOf(c) + 1;
}

char NumAChar(int n)
{
    string tabla = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ ";
    return tabla[n - 1];
}

string Cifrar(string mensaje, Queue<int> clave)
{
    string resultado = "";

    foreach (char c in mensaje)
    {
        int valor = CharANum(c);

        int k = clave.Dequeue();   
        clave.Enqueue(k);          

        int nuevo = valor + k;

        if (nuevo > 28)
            nuevo -= 28;

        resultado += NumAChar(nuevo);
    }

    return resultado;
}

string Descifrar(string mensaje, Queue<int> clave)
{
    string resultado = "";

    foreach (char c in mensaje)
    {
        int valor = CharANum(c);

        int k = clave.Dequeue();
        clave.Enqueue(k);

        int nuevo = valor - k;

        if (nuevo < 1)
            nuevo += 28;

        resultado += NumAChar(nuevo);
    }

    return resultado;
}

Queue<int> clave = new Queue<int>();
clave.Enqueue(5);
clave.Enqueue(3);
clave.Enqueue(9);
clave.Enqueue(7);

string mensaje = "HOLA MUNDO";

string cifrado = Cifrar(mensaje, new Queue<int>(clave));
Console.WriteLine(cifrado); 

string original = Descifrar(cifrado, new Queue<int>(clave));
Console.WriteLine(original); 