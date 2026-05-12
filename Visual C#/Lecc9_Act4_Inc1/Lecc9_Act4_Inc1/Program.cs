internal class Program
{
    private static void Main(string[] args)
    {
        int num;
        int i = 1;
        int result;

        Console.Write("Ingrese un número: ");
        num = Convert.ToInt32(Console.ReadLine());

        while (i <= 10)
        {
            result = num * i;

            Console.WriteLine(num + " x " + i + " = " + result);

            i++;
        }
    }
}