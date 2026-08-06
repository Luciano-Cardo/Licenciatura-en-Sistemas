// 19) Codificar el método Swap que recibe 2 parámetros enteros e intercambia sus valores. El cambio debe apreciarse en el método 
//     invocador.


static void Swap(ref int a, ref int b){
    int a2 = a;
    a = b;
    b = a2;
}
// static void Swap(ref int a, ref int b){
//     (a,b) = (b,a);
// }    

int a=10;
int b=5;

Console.WriteLine("Antes: a="+a+" y b="+b);
Swap(ref a,ref b);
Console.WriteLine("Despues: a="+a+" y b="+b);