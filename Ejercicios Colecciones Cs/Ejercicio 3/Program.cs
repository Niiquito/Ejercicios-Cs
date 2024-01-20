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
        agregarElementos(nombres);
        mostrarElementos(nombres);
        nombres.Remove("");
        borrarElementos(nombres);
        nombres.Add(Console.ReadLine());
        nombres.Sort();
        Console.WriteLine();
        mostrarElementos(nombres);
    }

    private static void agregarElementos(List<string> nombres)
    {
        do
        {
            nombres.Add(Console.ReadLine());
        } while (!nombres.Contains(""));
    }

    private static void borrarElementos(List<string> nombres)
    {
        for (int i = 0; i < nombres.Count; i++)
            if (nombres[i].StartsWith("A"))
            {
                nombres.RemoveAt(i);
                i--;
            }
    }

    private static void mostrarElementos(List<string> nombres)
    {
        foreach (string item in nombres)
            Console.WriteLine(item);
    }
}