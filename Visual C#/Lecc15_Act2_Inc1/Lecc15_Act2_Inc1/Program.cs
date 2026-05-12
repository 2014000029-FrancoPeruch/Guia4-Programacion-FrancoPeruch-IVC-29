internal class Program
{
    private static void Main(string[] args)
    {
        int cont;
        int cantidad = 0;
        int suma = 0;

        for (int num = 1; num <= 100; num++)
        {
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
                cantidad++;
                suma += num;
            }
        }

        Console.WriteLine("Cantidad de números primos: " + cantidad);
        Console.WriteLine("Suma de números primos: " + suma);
    }
}