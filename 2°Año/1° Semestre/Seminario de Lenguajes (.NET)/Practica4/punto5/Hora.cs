namespace punto5
{
    public class Hora
    {
        private int horas;
        private int minutos;
        private double segundos;
        private bool usarDecimales;

        public Hora(int h, int m, int s)
        {
            horas = h;
            minutos = m;
            segundos = s;
            usarDecimales = false;
        }

        public Hora(double horasDec)
        {
            horas = (int)horasDec;

            double resto = horasDec - horas;

            double totalMin = resto * 60;
            minutos = (int)totalMin;

            double restoMin = totalMin - minutos;
            segundos = restoMin * 60;

            usarDecimales = true;
        }

        public void Imprimir()
        {
            if (usarDecimales)
            {
                Console.WriteLine($"{horas:D2}:{minutos:D2}:{segundos:00.000}");
            }
            else
            {
                Console.WriteLine($"{horas:D2}:{minutos:D2}:{(int)segundos:D2}");
            }
        }
    }
}
