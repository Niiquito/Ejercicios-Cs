namespace Ejercicio3;
public class Ejercicio3
{
    /*Crear una lista de nombres y, a continuación, 
      realizar las siguientes operaciones:

        Mostrar la lista en consola.
        Eliminar todos los nombres que comiencen por la letra "A".
        Añadir un nuevo nombre a la lista.
        Ordenar la lista alfabéticamente.*/
    static void Main()
    {
        List<string> nombres = new List<string>();
        nombres.Add("Alejandro");
        nombres.Add("Nittao");
        nombres.Add("Alejo");
        nombres.Add("Alita");
        nombres.Add("Nico");
        nombres.Add("Pedro");
        nombres.Add("Aedro");

        foreach (string item in nombres)
        {
            Console.WriteLine(item);
        }
        for (int i = 0; i < nombres.Count; i++)
        {
            if (nombres[i].StartsWith("A"))
            {
                nombres.RemoveAt(i);
                i--;
            }
        }
        nombres.Add("Pepe");
        nombres.Sort();
        Console.WriteLine();
        foreach (string item in nombres)
        {
            Console.WriteLine(item);
        }
    }
}