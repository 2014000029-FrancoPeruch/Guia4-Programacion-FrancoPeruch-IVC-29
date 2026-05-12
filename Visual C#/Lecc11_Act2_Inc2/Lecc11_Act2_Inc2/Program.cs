internal class Program
{
    private static void Main(string[] args)
    {
        int i = 1;

        do
        {
            if (i % 2 == 1)
            {
                Console.WriteLine(i);
            }

            i++;

        } while (i <= 100);
    }
}