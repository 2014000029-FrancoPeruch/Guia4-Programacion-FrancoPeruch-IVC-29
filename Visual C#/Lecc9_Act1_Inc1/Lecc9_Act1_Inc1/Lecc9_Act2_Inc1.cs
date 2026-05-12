internal class Lecc9_Act2_Inc1
{
    private static void Main(string[] args)
    {
        int mon = 0;

        while (mon < 350)
        {
            Console.WriteLine("===================");
            Console.WriteLine("Nivel 5 BLOQUEADO");
            Console.WriteLine("===================");
            Console.WriteLine("Cantidad de monedas: "+mon);
            Console.Write("Escriba su cantidad de monedas: ");
            mon += Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("=====================");
        Console.WriteLine("Nivel 5 DESBLOQUEADO");
        Console.WriteLine("=====================");
    }
}