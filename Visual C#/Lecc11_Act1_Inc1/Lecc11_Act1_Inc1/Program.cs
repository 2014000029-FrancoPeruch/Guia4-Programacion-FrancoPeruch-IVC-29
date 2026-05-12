internal class Program
{
    private static void Main(string[] args)
    {
        int autos = 0;
        int disp = 200;

        do
        {
            Console.WriteLine("Cajones disponibles: " + disp);

            autos++;
            disp--;

        } while (disp > 0);

        Console.WriteLine("Ya no hay cajones libres");
    }
}