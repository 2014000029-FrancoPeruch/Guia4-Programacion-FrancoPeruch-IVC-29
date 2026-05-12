internal class Program
{
    private static void Main(string[] args)
    {
        int tipo;
        int totalBoletos = 0;
        int totalDinero = 0;
        int op = 1;

        while (op == 1)
        {
            Console.WriteLine("========================");
            Console.WriteLine("1. Adulto ($15)");
            Console.WriteLine("2. Niño ($10)");
            Console.WriteLine("========================");

            Console.Write("Ingrese el tipo de boleto: ");
            tipo = Convert.ToInt32(Console.ReadLine());

            if (tipo == 1)
            {
                totalDinero += 15;
                totalBoletos++;
            }
            else if (tipo == 2)
            {
                totalDinero += 10;
                totalBoletos++;
            }

            Console.WriteLine("Boletos vendidos: " + totalBoletos);
            Console.WriteLine("Total cobrado: $" + totalDinero);

            Console.WriteLine("¿Desea vender otro boleto?");
            Console.WriteLine("1. Sí");
            Console.WriteLine("2. No");

            op = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("========================");
        Console.WriteLine("Ventas finalizadas");
        Console.WriteLine("Boletos vendidos: " + totalBoletos);
        Console.WriteLine("Total recaudado: $" + totalDinero);
    }
}