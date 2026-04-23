// 2) Aunque consultar en el código por el tipo de un objeto indica habitualmente un diseño ineficiente, por motivos didácticos vamos a utilizarlo.
//    Completar el siguiente código, que utiliza las clases definidas en el ejercicio anterior, para que se produzca la salida indicada:

//    A[] vector = [ new C(1),new D(2),new B(3),new D(4),new B(5)];
//    foreach (A a in vector)
//    {
//         ...
//    }

//    Es decir, se deben imprimir sólo los objetos cuyo tipo exacto sea B
//    a) Utilizando el operador is
//    b) Utilizando el método GetType() y el operador typeof() (investigar sobre éste último en la documentación en línea de .net)

Console.WriteLine("Inciso A");
A[] vector = { new C(1), new D(2), new B(3), new D(4), new B(5) };
foreach (A a in vector)
{
    if (a is B && !(a is C) && !(a is D))
    {
        a.Imprimir();
    }
}

Console.WriteLine("Inciso B");
A[] vector = { new C(1), new D(2), new B(3), new D(4), new B(5) };

foreach (A a in vector)
{
    if (a.GetType() == typeof(B))
    {
        a.Imprimir();
    }
}

