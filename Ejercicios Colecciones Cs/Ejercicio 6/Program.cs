namespace Ejercicio6;
public class Ejercicio6
{
    /*
        Crear una lista de números enteros y, a continuación, 
        realizar las siguientes operaciones:

            Mostrar la lista en consola.
            Eliminar todos los números negativos de la lista.
            Añadir un nuevo número al final de la lista.
            Ordenar la lista de mayor a menor.
    */
    static void Main()
    {
        List<int> numeros = new List<int>();
        agregarNumeros(numeros);
        numeros.Remove(0);
        Console.WriteLine();
        mostrarLista(numeros);
        Console.WriteLine();
        for (int i = 0; i < numeros.Count; i++)
        {
            if (numeros[i] < 0)
                numeros.RemoveAt(i);
        }
        Console.WriteLine();
        numeros.Add(int.Parse(Console.ReadLine()));
        Console.WriteLine();
        numeros.Sort();
        numeros.Reverse();
        mostrarLista(numeros);
    }

    private static void agregarNumeros(List<int> numeros)
    {
        do
        {
            try
            {
                numeros.Add(int.Parse(Console.ReadLine()));
            }
            catch (Exception e)
            {
                Console.WriteLine("Error, ingrese nuevamente", e);
            }
        } while (!numeros.Contains(0));
    }

    private static void mostrarLista(List<int> numeros)
    {
        foreach (int item in numeros)
            Console.WriteLine(item);
    }
}