internal class Program
{
    private static void Main(string[] args)
    {
        int num;
        int i = 1; 
        int cont = 0;

        Console.Write("Ingrese un número entero: ");
        num = Convert.ToInt32(Console.ReadLine());

        while (i <= num)
        {
            if (num % i == 0)
            {
                cont++;
            }

            i++;
        }

        if (cont == 2)
        {
            Console.WriteLine("El número es primo");
        }
        else
        {
            Console.WriteLine("El número no es primo");
        }
    }
}