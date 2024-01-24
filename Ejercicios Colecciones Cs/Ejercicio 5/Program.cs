namespace Ejercicio5;
public class Ejercicio5
{
    /*
      Crear una lista de palabras y, a continuación, 
      realizar las siguientes operaciones:
            Mostrar la lista en consola.
            Eliminar todas las palabras que sean menores de 5 caracteres.
            Añadir una nueva palabra al principio de la lista.
            Ordenar la lista alfabéticamente.
    */
    static void Main()
    {
        List<string> palabras = new List<string>();
        agregarElementos(palabras);
        Console.WriteLine("Lista de palabras ingresadas");
        mostrarLista(palabras);
        Console.WriteLine();
        removerPalabrasMenores(palabras);
        Console.Write("Ingrese nueva palabra: ");
        palabras.Add(Console.ReadLine());
        palabras.Sort();
        Console.WriteLine();
        mostrarLista(palabras);
    }

    private static void removerPalabrasMenores(List<string> palabras)
    {
        for (int i = 0; i < palabras.Count; i++)
            if (palabras[i].Length < 5)
            {
                palabras.RemoveAt(i);
                i--;
            }
    }

    private static void mostrarLista(List<string> palabras)
    {
        foreach (string item in palabras)
            Console.WriteLine(item);
    }
    private static void agregarElementos(List<string> palabras)
    {
        do
        {
            try
            {
                palabras.Add(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Error, ingrese nuevamente", e);
            }
        } while (!palabras.Contains(""));
    }
}