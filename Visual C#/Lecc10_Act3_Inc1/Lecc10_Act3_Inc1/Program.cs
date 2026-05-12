internal class Program
{
    private static void Main(string[] args)
    {
        int cont;
        int suma = 0;
        int num;
        int i;

        for (num = 1; num <= 22; num++)
        {
            cont = 0;

            for (i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    cont++;
                }
            }

            if (cont == 2)
            {
                suma += num;
            }
        }

        Console.WriteLine("La suma de los números primos es: " + suma);
    }
}