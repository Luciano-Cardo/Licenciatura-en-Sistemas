namespace punto4;

public class Ingresador
{
    public event EventHandler? LineaVaciaIngresada;
    public event EventHandler<NumeroIngresadoEventArgs>? NroIngresado;

    public void Ingresar()
    {
        string st = Console.ReadLine() ?? "";

        while (st.ToLower() != "fin")
        {
            if (st == "")
            {
                LineaVaciaIngresada?.Invoke(this, EventArgs.Empty);
            }

            if (int.TryParse(st, out int nro))
            {
                NroIngresado?.Invoke(this,
                    new NumeroIngresadoEventArgs(nro));
            }

            st = Console.ReadLine() ?? "";
        }
    }
}
