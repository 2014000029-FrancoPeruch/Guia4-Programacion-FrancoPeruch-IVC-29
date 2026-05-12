internal class Program
{
    private static void Main(string[] args)
    {
        int num;
        int suma = 0;

        do
        {
            Console.Write("Ingrese un número: ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num != 9)
            {
                suma += num;
            }

        } while (num != 9);

        Console.WriteLine("La suma total es: " + suma);
    }
}