internal class Program
{
    private static void Main(string[] args)
    {
        int num;
        int result;

        Console.Write("Ingrese un número: ");
        num = int.Parse(Console.ReadLine());

        for (int i = 1; i <= 20; i++)
        {
            result = num * i;

            Console.WriteLine(result);
        }
    }
}