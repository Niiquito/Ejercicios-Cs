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
        numeros.Add(10);
        numeros.Add(-1);
        numeros.Add(20);
        numeros.Add(-2);
        numeros.Add(30);
        foreach (int item in numeros)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
        for (int i = 0; i < numeros.Count; i++)
        {
            if (numeros[i] < 0)
            {
                numeros.RemoveAt(i);
            }
        }
        Console.WriteLine();
        numeros.Add(25);
        numeros.Sort();
        numeros.Reverse();
        foreach (int item in numeros)
        {
            Console.WriteLine(item);
        }
    }
}