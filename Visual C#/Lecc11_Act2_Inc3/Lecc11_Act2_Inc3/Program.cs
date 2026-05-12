internal class Program
{
    private static void Main(string[] args)
    {
        int num1, num2, men, may, i;

        Console.Write("Ingrese el primer número: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        if (num1 < num2)
        {
            men = num1;
            may = num2;
        }
        else
        {
            men = num2;
            may = num1;
        }

        i = men;

        do
        {
            if (i % 4 == 0)
            {
                Console.WriteLine(i);
            }

            i++;

        } while (i <= may);
    }
}