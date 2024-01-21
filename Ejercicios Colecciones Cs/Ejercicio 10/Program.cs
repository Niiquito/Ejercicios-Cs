namespace Ejercicio10;
public class Ejercicio10
{
    /* 
        Crear una lista de números enteros y, a continuación, realizar las siguientes operaciones:

            Mostrar la lista en consola.
            Ordenar la lista de menor a mayor.
            Dividir la lista en dos sublistas, una con los números pares y otra con los números impares.
            Mostrar en consola cada sublista.
    */
    static void Main()
    {
        List<int> numeros = new List<int>();
        List<int> numerosPares = new List<int>();
        List<int> numerosImpares = new List<int>();
        agregarElementos(numeros);
        numeros.Remove(0);
        mostrarLista(numeros);
        numeros.Sort();
        obtenerParImpar(numeros, numerosPares, numerosImpares);
        Console.WriteLine("\n Numeros pares");
        mostrarLista(numerosPares);
        Console.WriteLine("\n Numeros impares");
        mostrarLista(numerosImpares);
    }

    private static void agregarElementos(List<int> numeros)
    {
        try
        {
            do
            {
                numeros.Add(int.Parse(Console.ReadLine()));
            } while (!numeros.Contains(0));

        }
        catch (Exception e)
        {
            Console.WriteLine("Error, ingrese nuevamente");
        }
    }

    private static void obtenerParImpar(List<int> numeros, List<int> numerosPares, List<int> numerosImpares)
    {
        foreach (int item in numeros)
        {
            if (item % 2 == 0)
                numerosPares.Add(item);
            else
                numerosImpares.Add(item);
        }
    }

    private static void mostrarLista(List<int> numeros)
    {
        foreach (int item in numeros)
            Console.WriteLine(item);
    }
}