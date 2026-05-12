internal class Program
{
    private static void Main(string[] args)
    {
        int num;
        int cont;
        int result;
        Console.Write("Ingrese un número: ");
        num = int.Parse(Console.ReadLine());

        cont = 1;

        while (cont <= 10)
        {
            result = num * cont;

            Console.WriteLine(num + " x " + cont + " = " + result);

            cont++;
        }
    }
}