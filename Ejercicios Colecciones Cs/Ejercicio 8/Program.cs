namespace Ejercicio8;
public class Ejercicio8
{
    /*
        Crear una lista de números enteros y, a continuación, 
        realizar las siguientes operaciones:

            Mostrar la lista en consola.
            Eliminar todas las repeticiones de la lista.
    */
    static void Main()
    {
        List<int> numeros = new List<int>();
            agregarNumeros(numeros);
            Console.WriteLine();
            numeros.Remove(0);
            mostrarElementos(numeros);
            numeros.Sort();
            Console.WriteLine();
            eliminarRepeticiones(numeros);
            mostrarElementos(numeros);
    }

    private static void eliminarRepeticiones(List<int> numeros)
    {
        for (int i = 0; i < numeros.Count - 1; i++)
            if (numeros[i] == numeros[i + 1])
            {
                numeros.RemoveAt(i);
                i--;
            }
    }

    private static void mostrarElementos(List<int> numeros)
    {
        foreach (int item in numeros)
            Console.WriteLine(item);
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

    /*
     // Eliminar todas las repeticiones de la lista
    FORMA IA:
            List<int> numerosSinRepeticiones = new List<int>();
            for (int i = 0; i < numeros.Count; i++)
            {
                if (!numerosSinRepeticiones.Contains(numeros[i]))
                {
                    numerosSinRepeticiones.Add(numeros[i]);
                }
            }
     */
}