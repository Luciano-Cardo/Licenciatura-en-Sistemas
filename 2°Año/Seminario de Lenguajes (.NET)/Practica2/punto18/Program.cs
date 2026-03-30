// 18) Idem. al ejercicio 17.a) y 17.b) pero devolviendo el resultado en un parámetro de salida void Fac(int n, out int f)

//Inciso A
static void FacA(int nA, out int fA){
    fA=1;
    for (int i = 1; i <= nA; i++){
        fA *= i;
    }
}

int nA = int.Parse(args[0]);
FacA(nA,out int resultadoA);
Console.WriteLine("El factorial del numero "+nA+" es "+resultadoA);

//Inciso B
static void FacB(int nB, out int fB){
    if (nB == 0 || nB == 1){
       fB = 1;
    }else{
        FacB(nB-1,out int result);
        fB = nB * result;
    }
}

int nB = int.Parse(args[1]);
FacB(nB,out int resultadoB);
Console.WriteLine("El factorial del numero "+nB+" es "+resultadoB);