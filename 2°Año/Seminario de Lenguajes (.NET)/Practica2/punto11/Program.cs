// 11) Definir el tipo de datos enumerativo llamado Meses y utilizarlo para:
//      a) Imprimir en la consola el nombre de cada uno de los meses en orden inverso (diciembre,
//         noviembre, octubre ..., enero)
//      b) Solicitar al usuario que ingrese un texto y responder si el texto tipeado corresponde al nombre de
//         un mes
//     Nota: en todos los casos utilizar un for iterando sobre una variable de tipo Meses

for (int i = (int)Meses.Diciembre; i >= (int)Meses.Enero; i--)
{
    
    Meses mes = (Meses)i;
    Console.Write(mes+"-");
}

Console.WriteLine();

Console.Write("Ingrese un texto: ");
string texxto = Console.ReadLine();
Meses mes1;
bool esMes = Enum.TryParse(texxto,true, out mes1);
if (esMes){
    Console.WriteLine("El  texto corresponde a un mes");
}
else{
    Console.WriteLine("El texto no corresponde a un mes");
}

enum Meses {Enero, Febrero, Marzo, Abril, Mayo, Junio, Julio, Agosto, Septiembre, Octubre, Noviembre, Diciembre}