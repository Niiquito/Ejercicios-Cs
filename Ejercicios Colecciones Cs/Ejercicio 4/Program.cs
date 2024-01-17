namespace Ejercicio4;
public class Ejercicio4
{
    /*Crear una lista de números enteros y, a continuación, 
      realizar las siguientes operaciones:

        Mostrar la lista en consola.
        Eliminar todos los números pares de la lista.
        Añadir un nuevo número al principio de la lista.
        Ordenar la lista de menor a mayor.
    */
    static void Main()
    {
        List<int> numeros = new List<int>();
        agregarNumeros(numeros);
        mostrarLista(numeros);
        Console.WriteLine();
        removerPares(numeros);
        Console.WriteLine();
        mostrarLista(numeros);
        Console.WriteLine();
        //Insertar numero en la primera posición
        numeros.Insert(0, 10);
        mostrarLista(numeros);
        //Ordenado menor a mayor
        numeros.Sort();
        Console.WriteLine();
        mostrarLista(numeros);
        Console.ReadKey();
        Console.Clear();
        /*
            Mostrar la lista en consola.
            Eliminar todos los números que sean divisibles por 3.
            Añadir un nuevo número al final de la lista.
            Ordenar la lista de mayor a menor.
        */
        mostrarLista(numeros);
        Console.WriteLine();
        removerImpares(numeros);
        mostrarLista(numeros);
        Console.WriteLine();
        numeros.Insert(numeros.Count - 1, 5);
        mostrarLista(numeros);
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
    private static void removerImpares(List<int> numeros)
    {
        for (int i = 0; i < numeros.Count; i++)
            if (numeros[i] % 3 == 0 || numeros[i] == 1)
            {
                numeros.RemoveAt(i);
                i--;
            }
    }

    private static void mostrarLista(List<int> lista)
    {
        foreach (int item in lista)
            Console.WriteLine(item);
    }

    private static void removerPares(List<int> numeros)
    {
        for (int i = 0; i < numeros.Count; i++)
            if (numeros[i] % 2 == 0)
            {
                numeros.RemoveAt(i);
                i--;
            }
    }
}