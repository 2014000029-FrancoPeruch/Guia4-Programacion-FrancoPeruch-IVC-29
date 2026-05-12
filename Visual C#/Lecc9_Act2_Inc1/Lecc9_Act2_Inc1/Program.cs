internal class Program
{
    private static void Main(string[] args)
    {
        int monedas = 0;
        int agregar;

        Console.WriteLine("=== DESBLOQUEO DEL NIVEL 5 ===");
        Console.WriteLine("Necesitas 350 monedas para entrar al nivel 5.");

        while (monedas < 350)
        {
            Console.Write("Ingrese las monedas ganadas: ");
            agregar = Convert.ToInt32(Console.ReadLine());

            monedas = monedas + agregar;

            Console.WriteLine("Monedas actuales: " + monedas);

            if (monedas < 350)
            {
                Console.WriteLine("El nivel 5 sigue bloqueado.\n");
            }
        }
    }
}