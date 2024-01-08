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
        numeros.Add(1);
        numeros.Add(2);
        numeros.Add(3);
        numeros.Add(4);
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
    }

    private static void mostrarLista(List<int> lista)
    {
        foreach (int item in lista)
        {
            Console.WriteLine(item);
        }
    }

    private static void removerPares(List<int> numeros)
    {
        for (int i = 0; i < numeros.Count; i++)
        {
            if (numeros[i] % 2 == 0)
            {
                numeros.RemoveAt(i);
                i--;
            }
        }
    }
}