internal class Program
{
    private static void Main(string[] args)
    {
        int num;
        int i;

        Console.Write("Ingrese un número");
        num = Convert.ToInt32(Console.ReadLine());

        if (num >= 20)
        {
            i = 20;
            while (i <= num)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
                i ++;
            }
        }
        else
        {
            i = num;

            while (i <= 20)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
                i++;
            }
        }

    }
}