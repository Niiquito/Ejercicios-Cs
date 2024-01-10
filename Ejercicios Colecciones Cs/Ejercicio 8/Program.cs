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
        numeros.Add(10);
        numeros.Add(10);
        numeros.Add(30);
        numeros.Add(20);
        numeros.Add(30);
        numeros.Add(40);
        foreach (int item in numeros)
            Console.WriteLine(item);
        numeros.Sort();
        Console.WriteLine();
        for (int i = 0; i < numeros.Count - 1; i++)
            if (numeros[i] == numeros[i+1] )
                numeros.RemoveAt(i);
        foreach (int item in numeros)
            Console.WriteLine(item);
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