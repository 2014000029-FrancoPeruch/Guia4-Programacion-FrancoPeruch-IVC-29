internal class Program
{
    private static void Main(string[] args)
    {
        int num;
        int i = 1;
        int fact = 1;

        Console.Write("Ingrese un número: ");
        num = Convert.ToInt32(Console.ReadLine());

        do
        {
            fact *= i;
            i++;

        } while (i <= num);

        Console.WriteLine("El factorial es: " + fact);
    }
}