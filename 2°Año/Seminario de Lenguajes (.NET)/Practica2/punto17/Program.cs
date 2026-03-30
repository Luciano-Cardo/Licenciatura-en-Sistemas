// 17) Escribir una función (método int Fac(int n)) que calcule el factorial de un número n pasado al programa como parámetro por 
//     la línea de comando
//         a) Definiendo una función no recursiva
//         b) Definiendo una función recursiva
//         c) idem a b) pero con expression-bodied methods (Tip: utilizar el operador condicional ternario)

//Inciso A
static int FacA(int nA){
    int resultado=1;
    for (int i = 1; i <= nA; i++){
        resultado *= i;
    }
    return resultado;
}

int nA = int.Parse(args[0]);
Console.WriteLine("El factorial del numero "+nA+" es "+FacA(nA));

//Inciso B
static int FacB(int nB){
    if (nB == 0 || nB == 1)
        return 1;

    return nB * FacB(nB - 1);
}

int nB = int.Parse(args[1]);
Console.WriteLine("El factorial del numero "+nB+" es "+FacB(nB));

//Inciso C
static int FacC(int nC) => (nC == 0 || nC == 1) ? 1 : nC * FacC(nC - 1);

int nC = int.Parse(args[2]);
Console.WriteLine("El factorial del numero "+nC+" es "+FacC(nC));