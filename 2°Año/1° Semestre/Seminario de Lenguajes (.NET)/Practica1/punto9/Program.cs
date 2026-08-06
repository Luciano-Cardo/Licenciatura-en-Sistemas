// 9) Escribir un programa que lea dos palabras separadas por un blanco que terminan con <ENTER>, y determinar si son simétricas 
//    (Ej: 'abbccd' y 'dccbba' son simétricas).
//    Tip: si st es un string, entonces st[0] devuelve el primer carácter de st, y st[st.Length-1] devuelve el último carácter de st.

Console.WriteLine("Ingrese dos palabras separadas por un espacio:");
string input = Console.ReadLine();

string[] partes = input.Split(' ');

string palabra1 = partes[0];
string palabra2 = partes[1];

if (SonSimetricas(palabra1, palabra2))
    Console.WriteLine("Son simétricas");
else
    Console.WriteLine("No son simétricas");


static bool SonSimetricas(string a, string b){
    if (a.Length != b.Length)
        return false;

    for (int i = 0; i < a.Length; i++){
        if (a[i] != b[b.Length - 1 - i])
            return false;
    }
    return true;
}