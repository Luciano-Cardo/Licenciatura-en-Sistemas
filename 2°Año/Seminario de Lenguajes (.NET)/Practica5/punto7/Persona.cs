namespace punto7;

public class Persona
{
    private String? _nombre {get; set;}
    private char _sexo {get; set;}
    private int _dni {get; set;}
    private DateTime _fechaNacimiento {get; set;}
    public int _edad
    {
        get
        {
            int edad = DateTime.Today.Year - _fechaNacimiento.Year;
            return edad;
        }
    }
    public object this[int i]
    {
        get
        {
            switch (i)
            {
                case 0: return _nombre;
                case 1: return _sexo;
                case 2: return _dni;
                case 3: return _fechaNacimiento;
                case 4: return _edad;
                default: throw new IndexOutOfRangeException();
            }
        }
        set
        {
            switch (i)
            {
                case 0: _nombre = (string)value; break;
                case 1: _sexo = (char)value; break;
                case 2: _dni = (int)value; break;
                case 3: _fechaNacimiento = (DateTime)value; break;
                case 4: break;
                default: throw new IndexOutOfRangeException();
            }
        }
    }
}
