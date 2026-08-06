// 8) Prestar atención a los siguientes programas (ninguno funciona correctamente):

//     Foo f = new Foo();
//     f.Imprimir();
//     class Foo
//     {
//         string? _bar;
//         public void Imprimir()
//         {
//             Console.WriteLine(_bar.Length);
//         }
//     }

//     Foo f = new Foo();
//     f.Imprimir();
//     class Foo
//     {
//         public void Imprimir()
//         {
//             string? bar;
//             Console.WriteLine(bar.Length);
//         }
//     }

//     ¿Qué se puede decir acerca de la inicialización de los objetos? ¿En qué casos son inicializados
//     automáticamente y con qué valor?

Console.WriteLine("En C#, los campos de una clase se inicializan automáticamente con valores por defecto; en el caso de tipos de"+
                  "referencia como string, el valor inicial es null. Por eso, en el primer programa _bar vale null, y al acceder"+
                  "a _bar.Length se produce una excepción en tiempo de ejecución. En cambio, las variables locales no se "+
                  "inicializan automáticamente, por lo que en el segundo programa se produce un error de compilación al intentar "+
                  "usar la variable bar sin haberle asignado un valor.");