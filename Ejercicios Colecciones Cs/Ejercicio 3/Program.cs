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
        do
        {
            nombres.Add(Console.ReadLine());
        } while (!nombres.Contains(""));
        foreach (string item in nombres)
            Console.WriteLine(item);
        nombres.Remove("");
        for (int i = 0; i < nombres.Count; i++)
        {
            if (nombres[i].StartsWith("A"))
            {
                nombres.RemoveAt(i);
                i--;
            }
        }
        nombres.Add(Console.ReadLine());
        nombres.Sort();
        Console.WriteLine();
        foreach (string item in nombres)
            Console.WriteLine(item);
    }
}