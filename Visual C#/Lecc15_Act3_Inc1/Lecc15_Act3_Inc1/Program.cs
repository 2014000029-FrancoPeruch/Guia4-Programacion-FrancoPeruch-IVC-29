internal class Program
{
    private static void Main(string[] args)
    {
        int mult;
        int suma = 0;
        int pares = 0;

        for (int i = 1; i <= 20; i++)
        {
            mult = 7 * i;

            suma += mult;

            if (mult % 2 == 0)
            {
                pares++;
            }
        }

        Console.WriteLine("La sumatoria es: " + suma);
        Console.WriteLine("Cantidad de múltiplos pares: " + pares);
    }
}