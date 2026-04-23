// 6) Señalar el error en cada uno de los siguientes casos:

//     (6.1)
//     class A
//     {
//         public string M1() => "A.M1";
//     }
//     class B : A
//     {
//         public override string M1() => "B.M1"; //Override invalido(el metodo A no es virtual)
//     }

//     (6.2)
//     class A
//     {
//         public abstract string M1(); //Método abstracto en clase no abstracta
//     }
//     class B : A
//     {
//         public override string M1() => "B.M1";
//     }

//     (6.3)
//     abstract class A
//     {
//         public abstract string M1() => "A.M1"; //Método abstract no puede tener implementación
//     }
//     class B : A
//     {
//         public override string M1() => "B.M1";
//     }

//     (6.4)
//     class A
//     {
//         public override string M1() => "A.M1"; //No se puede usar override si no heredás de nada
//     }
//     class B : A
//     {
//         public override string M1() => "B.M1";
//     }

//     (6.5)
//     class A
//     {
//         public virtual string M1() => "A.M1";
//     }
//     class B : A
//     {
//         protected override string M1() => "B.M1"; //Cambia la accesibilidad
//     }

//     (6.6)
//     class A
//     {
//         public static virtual string M1() => "A.M1"; //Static y virtual son incompatibles
//     }
//     class B : A
//     {
//         public static override string M1() => "B.M1";
//     }

//     (6.7)
//     class A
//     {
//         virtual string M1() => "A.M1"; //Falta modificador de acceso
//     }
//     class B : A
//     {
//         override string M1() => "B.M1";
//     }

//     (6.8)
//     class A
//     {
//         protected A(int i) { }
//     }
//     class B : A
//     {
//         B() { } //B no llama al constructor base
//     }

//     (6.9)
//     class A
//     {
//         private int _id;
//         protected A(int i) => _id = i;
//     }
//     class B : A
//     {
//         B(int i):base(5) {
//             _id = i;  //_id es private en A
//         }
//     }

//     (6.10)
//     class A
//     {
//         private int Propiedad { set; public get; } //Modificadores inconsistentes (no se puede tener la propiedad private y el get public)
//     }
//     class B : A
//     {
//     }

//     (6.11)
//     abstract class A
//     {
//         public abstract int Prop {set; get;}
//     }
//     class B : A //Falta implementar set (la propiedad abstracta tiene get y set)
//     {
//         public override int Prop
//         {
//             get => 5;
//         }
//     }

//     (6.12)
//     abstract class A
//     {
//         public int Prop {set; get;}
//     }
//     class B : A
//     {
//         public override int Prop { //No se puede usar override (en A la propiedad no es virtual ni abstract)
//             get => 5;
//             set {}
//         }
//     }
