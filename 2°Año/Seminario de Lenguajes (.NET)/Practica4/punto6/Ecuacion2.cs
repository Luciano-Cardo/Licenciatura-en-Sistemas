namespace punto6{ 
    public class Ecuacion2{
        private double a;
        private double b;
        private double c;

        public Ecuacion2(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double GetDiscriminante()
        {
            return (b * b) - (4 * a * c);
        }

        public int GetCantidadDeRaices()
        {
            double discriminante = GetDiscriminante();

            if (discriminante < 0)
                return 0;
            else if (discriminante == 0)
                return 1;
            else
                return 2;
        }
        public void ImprimirRaices()
        {
            double discriminante = GetDiscriminante();

            if (discriminante < 0)
            {
                Console.WriteLine("La ecuación no tiene raíces reales.");
            }
            else if (discriminante == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine("La ecuación tiene una única raíz: " + x);
            }
            else
            {
                double raiz1 = (-b + Math.Sqrt(discriminante)) / (2 * a);
                double raiz2 = (-b - Math.Sqrt(discriminante)) / (2 * a);

                Console.WriteLine("La ecuación tiene dos raíces:");
                Console.WriteLine("x1 = " + raiz1);
                Console.WriteLine("x2 = " + raiz2);
            }
        }
    }
}