internal class Program
{
    private static void Main(string[] args)
    {
        int billete;
        int cantidad = 0;
        int suma = 0;

        for (int i = 1; i <= 1000; i++)
        {
            Console.Write("Ingrese el valor del billete: ");
            billete = Convert.ToInt32(Console.ReadLine());

            if (billete == 100)
            {
                cantidad++;
                suma += 100;
            }
        }

        Console.WriteLine("Cantidad de billetes de $100: " + cantidad);
        Console.WriteLine("Total de dinero en billetes de $100: $" + suma);
    }
}