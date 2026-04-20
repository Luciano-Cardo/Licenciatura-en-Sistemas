// 10) Identificar todos los miembros en la siguiente declaración de clase. Indicar si se trata de un constructor, método, campo, 
//     propiedad o indizador, si es estático o de instancia, y en caso que corresponda si es de sólo lectura, sólo escritura o lectura y 
//     escritura. En el caso de las propiedades indicar también si se trata de una propiedad auto-implementada.
//     Nota: La clase compila perfectamente. Sólo prestar atención a la sintaxis, la semántica es irrelevante.

//     class A
//     {
//         private static int a;               Campo-Estático-Lectura/escritura
//         private static readonly int b;      Campo-Estático-Solo lectura(readonly)
//         A() { }                             Constructor-de Instancia
//         public A(int i) : this() { }        Constructor-de Instancia-Sobrecargado (llama a otro constructor)
//         static A() => b = 2;                Constructor-Estático-Se ejecuta una sola vez
//         int c;                              Campo-de Instancia-Lectura/escritura
//         public static void A1() => a = 1;   Método-Estático
//         public int A1(int a) => A.a + a;    Método-de Instancia-Sobrecarga de A1
//         public static int A2;               Campo-Estático-Lectura/escritura
//         static int A3 => 3;                 Propiedad-Estática-Solo lectura(readonly)
//         private int A4() => 4;              Método-de Instancia
//         public int A5 { get => 5; }         Propiedad-de Instancia-Solo lectura(readonly)
//         int A6 { set => c = value; }        Propiedad-de Instancia-Solo escritura
//         public int A7 { get; set; }         Propiedad-De instancia-Lectura/escritura-Auto-implementada
//         public int A8 { get; } = 8;         Propiedad-De instancia-Solo lectura(readonly)-Auto-implementada
//         public int this[int i] => i;        Indizador-De instancia-Solo lectura(readonly)
//     }