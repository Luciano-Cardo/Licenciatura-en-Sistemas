namespace punto4
{
    public class Hora
    {
        private int horas;
        private int minutos;
        private int segundos;

        public Hora(int horas, int minutos, int segundos)
        {
            this.horas = horas;
            this.minutos = minutos;
            this.segundos = segundos;
        }

        public void Imprimir()
        {
            Console.WriteLine($"{horas:D2}:{minutos:D2}:{segundos:D2}");
        
        }
    }
}

