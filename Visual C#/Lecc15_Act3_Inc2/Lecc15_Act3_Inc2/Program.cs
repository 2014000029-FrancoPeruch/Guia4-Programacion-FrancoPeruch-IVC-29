internal class Program
{
    private static void Main(string[] args)
    {
        int cont;
        int cantidadPrimos = 0;
        int sumaPares = 0;

        for (int num = 300; num >= 1; num--)
        {
            if (num % 2 == 0)
            {
                sumaPares += num;
            }

            cont = 0;

            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    cont++;
                }
            }

            if (cont == 2)
            {
                cantidadPrimos++;
            }
        }

        Console.WriteLine("Cantidad de números primos: " + cantidadPrimos);
        Console.WriteLine("Suma de números pares: " + sumaPares);
    }
}