namespace punto7;

class Validador<T>
{
    private List<ReglaValidacion<T>> reglas = new();
    public Validador<T> AgregarRegla(ReglaValidacion<T> regla)
    {
        reglas.Add(regla);
        return this;
    }

    public bool Validar(T objeto, out List<string> errores)
    {
        errores = new List<string>();
        foreach (var regla in reglas)
        {
            if (!regla.Ok(objeto))
            {
                errores.Add(regla.MensajeError);
            }
        }
        return errores.Count == 0;
    }
}
