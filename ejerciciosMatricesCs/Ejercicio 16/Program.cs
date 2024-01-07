namespace Ejercicio16;
public class Ejercicio16
{
    struct Coche
    {
        public string Modelo;
        public int anioFabricacion;
    }
    static void Main()
    {
        Coche[] coche = new Coche[3];
        for (int i = 0; i < coche.Length; i++)
        {
            Console.Write("Ingrese Modelo: ");
            coche[i].Modelo = Console.ReadLine();
            Console.Write("Ingrese año de fabricación: ");
            coche[i].anioFabricacion = int.Parse(Console.ReadLine());
            Console.WriteLine();
        }
        Console.WriteLine();
        int auxiliar = 0;
        for (int i = 0; i < coche.Length - 1; i++)
        {
            for (int j = 0; j < coche.Length - 1; j++)
            {
                if (coche[j].anioFabricacion > coche[j+1].anioFabricacion)
                {
                    auxiliar = coche[j].anioFabricacion;
                    coche[j].anioFabricacion = coche[j+1].anioFabricacion;
                    coche[j+1].anioFabricacion = auxiliar;
                }
            }
        }
        for (int i = coche.Length - 1; i >= 0; i--)
        {
            Console.WriteLine($"Modelo: {coche[i].Modelo}, Año Fabricación: {coche[i].anioFabricacion}");
        }
        Console.WriteLine();
        for (int i = 0; i < coche.Length; i++)
        {
            Console.WriteLine($"Modelo: {coche[i].Modelo}, Año Fabricación: {coche[i].anioFabricacion}");
        }
    }
}