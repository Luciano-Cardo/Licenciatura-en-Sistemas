// 5) Qué líneas del código siguiente provocan error de compilación? Analizar cuándo es posible acceder a miembros estáticos y de 
//    instancia.

//     class A
//     {
//         char c;
//         static string st;
//         void metodo1()
//         {
//             st = "string";
//             c = 'A';
//         }
//         static void metodo2()
//         {
//             new ClaseA().c = 'a'; //ClaseA no existe , la clase es A (deberia ser new A().c = 'a';)
//             st = "st2";
//             c = 'B';              //Error, acceso a variable de instancia desde static
//             new A().st = "otro string";
//         }
//     }