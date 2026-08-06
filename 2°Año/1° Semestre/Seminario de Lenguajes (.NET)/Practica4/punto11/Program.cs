// 11) Reemplazar estas líneas de código por otras equivalentes que utilicen el operador null-coalescing
//     (?? ) y / o la asignación null-coalescing (??=)

//     ...
//     if (st1 == null)
//     {
//     if (st2 == null)
//     {
//     st = st3;
//     }
//     else
//     {
//     st = st2;
//     }
//     }
//     else
//     {
//     st = st1;
//     }
//     if (st4 == null)
//     {
//     st4 = "valor por defecto";
//     }
//     ...

string st1 = null;
string st2 = null;
string st3 = "tercer valor";
string st4 = null;
string st;
st = st1 ?? st2 ?? st3;
st4 ??= "valor por defecto";
Console.WriteLine("st: " + st);
Console.WriteLine("st4: " + st4);