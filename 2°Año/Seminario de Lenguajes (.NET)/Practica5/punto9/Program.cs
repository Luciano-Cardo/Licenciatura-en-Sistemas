// 9) ¿Cuál es el error en el siguiente programa?

//     Auto a = new Auto();
//     a.Marca = "Ford";
//     Console.WriteLine(a.Marca);
//     class Auto
//     {
//         private string marca;
//         public string Marca
//         {
//             set
//             {
//                 Marca = value;
//             }
//             get
//             {
//                 return marca;
//             }
//         }
//     }

//     Nota: Observar que utilizar la convención de prefijar a los campos privados con guión bajo, hace más difícil cometer este tipo de 
//     errores

Console.WriteLine("El error es recursión infinita en el setter de la propiedad.");