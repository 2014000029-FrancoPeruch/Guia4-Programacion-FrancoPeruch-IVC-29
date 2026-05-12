internal class Program
{
    private static void Main(string[] args)
    {
        //Variables
        int pesomanzana, pesototal, cont;
        //Inicializar variables
        pesomanzana = 0;
        pesototal = 0;
        cont = 0;

        while (pesototal < 1000)
        {
            Console.Write("Ingrese el peso de la manzana: ");
            pesomanzana = Convert.ToInt32(Console.ReadLine());

            if (pesomanzana >= 180)
            {
                pesototal+= pesomanzana;
                Console.WriteLine("Leva un peso total de: " + pesototal + " gramos.");
                cont++;
            }
            else
            {
                Console.WriteLine("ERROR - La manzana debe de pesar al menos 180 gramos.");
            }
        }
        Console.WriteLine("Ya se alcanzó el kilo de peso en manzanas.");
        Console.WriteLine("Usted compró: "+cont+" manzanas.");
    }
}