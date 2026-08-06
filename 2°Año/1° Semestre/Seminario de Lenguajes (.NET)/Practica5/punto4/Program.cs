// 4) Indicar en cada caso si la definición de la clase A es correcta, en caso de no serlo detallar cuál es el error.

//     4. a) 
//     class A 
//     {
//         static int s_a=0;
//         static A() {
//             s_a++;
//         }
//         public A() {
//             s_a++;
//         }
//     }

//     4. b) 
//     class A 
//     {
//         static int s_a = 0;
//         public static A() {
//             s_a++;
//         }
//         A() {
//             s_a++;
//         }
//     }

//     4. c)
//     class A 
//     {
//         static int s_a = 0;
//         static A(int a) {
//             s_a=a;
//         }
//         A(int a) {
//             s_a = a;
//         }
//     }

//     4. d)
//     class A 
//     {
//         static int s_a = 0;
//         int a = 0;
//         static A() {
//             s_a = 30;
//         }
//         A(int a) {
//             s_a = a;
//             this.a = a;
//         }
//     }

//     4. e)
//     class A 
//     {
//         static int s_a = 0;
//         int a = 0;
//         static A() {
//             a = 30;
//         }
//         A(int a) {
//             a = s_a;
//         }
//     }

//     4. f)
//     class A
//     {
//         static int s_a = 1;
//         int a = 0;
//         static A() => s_a += s_a;
//         public static A GetInstancia() => new A(1);
//         A(int a) => this.a = a + s_a;
//     }

//     4. g)
//     class A
//     {
//         const double PI = 3.1416;
//         static double DoblePI = 2 * PI;
//     }

//     4. h)
//     class A
//     {
//         static double PI = 3.1416;
//         const double DoblePI = 2*PI;
//     }

//     4. i)
//     class A 
//     {
//         static readonly List<int> _lista;
//         static A() {
//             _lista = new List<int>();
//         }
//         public static void P(int i) {
//             _lista.Add(i);
//         }
//     }

//     4. j)
//     class A 
//     {
//         static readonly List<int> _lista;
//         static A() {
//             _lista = new List<int>();
//         }
//         public static void P(List<int> li) {
//             _lista = li;
//         }
//     }

//     4. k)
//     class A
//     {
//         static int[] vector = { 1, 2, 3 };
//         public int this[int i]
//         {
//             get { return vector[i]; }
//         }
//     }

//     4. l)
//     class A
//     {
//         static int[] vector = { 1, 2, 3 };
//         public static int this[int i]
//         {
//             get { return vector[i]; }
//         }
//     }

Console.WriteLine("El inciso A es valido");
Console.WriteLine("El inciso B es invalido ya que un constructor no puede ser static y tener modificador de acceso (public)");
Console.WriteLine("El inciso C es invalido ya que los constructores estáticos NO pueden tener parámetros");
Console.WriteLine("El inciso D es valido");
Console.WriteLine("El inciso E es invalido ya que a no es estático, y el constructor estático no puede acceder a variables de instancia");
Console.WriteLine("El inciso F es valido");
Console.WriteLine("El inciso G es valido");
Console.WriteLine("El inciso H es invalido ya que const debe inicializarse con valores constantes en tiempo de compilación y PI es static, no const");
Console.WriteLine("El inciso I es valido");
Console.WriteLine("El inciso J es invalido readonly no puede reasignarse fuera del constructor");
Console.WriteLine("El inciso K es valido");
Console.WriteLine("El inciso L es invalido ya que los indexadores no pueden ser static en C#");