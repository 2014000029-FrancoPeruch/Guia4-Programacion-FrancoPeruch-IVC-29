internal class Program
{
    private static void Main(string[] args)
    {
        int num;
        int suma = 0;

        Console.Write("Ingrese un número: ");
        num = int.Parse(Console.ReadLine());

        for (int i = num; i >= 1; i--)
        {
            Console.WriteLine(i);

            suma += i;
        }

        Console.WriteLine("La suma es: " + suma);
    }
}