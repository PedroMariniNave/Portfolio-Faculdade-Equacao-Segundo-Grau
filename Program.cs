namespace Portfolio
{
    public class Program
    {
        public static void Main()
        {
            bool isCalculating = true;

            while (isCalculating)
            {
                Console.WriteLine("Digite o valor de A: ");
                double a = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite o valor de B: ");
                double b = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite o valor de C: ");
                double c = Convert.ToDouble(Console.ReadLine());

                double delta = CalcularDelta(a, b, c);
                Console.WriteLine("");
                Console.WriteLine($"Delta: {delta}");

                if (delta < 0)
                {
                    Console.WriteLine("A equação não possui raízes reais.");
                    VerificarSeDesejaCalcularNovamente(ref isCalculating);
                    continue;
                }

                double[] raizes = CalcularRaizes(a, b, delta);
                Console.WriteLine($"X1: {raizes[0]}");
                Console.WriteLine($"X2: {raizes[1]}");

                VerificarSeDesejaCalcularNovamente(ref isCalculating);
            }
        }

        private static double CalcularDelta(double a, double b, double c)
        {
            return Math.Pow(b, 2) - 4 * a * c;
        }

        private static double[] CalcularRaizes(double a, double b, double delta)
        {
            double[] raizes = new double[2];

            if (delta == 0)
            {
                raizes[0] = raizes[1] = -b / (2 * a);
            }
            else
            {
                raizes[0] = (-b + Math.Sqrt(delta)) / (2 * a);
                raizes[1] = (-b - Math.Sqrt(delta)) / (2 * a);
            }

            return raizes;
        }

        private static void VerificarSeDesejaCalcularNovamente(ref bool isCalculating)
        {
            Console.WriteLine("");
            Console.WriteLine("Deseja calcular novamente?");
            Console.WriteLine("S/N");
            Console.WriteLine("");

            var input = Console.ReadLine();
            isCalculating = input.Equals("S", StringComparison.InvariantCultureIgnoreCase);

            Console.WriteLine("");
        }
    }
}