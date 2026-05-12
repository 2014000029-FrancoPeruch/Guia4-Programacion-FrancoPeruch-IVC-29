internal class Program
{
    private static void Main(string[] args)
    {
        int cont;
        int suma = 0;

        for (int num = 2; num <= 50; num++)
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
                Console.WriteLine(num);
                suma += num;
            }
        }

        Console.WriteLine("La suma de los números primos es: " + suma);
    }
}