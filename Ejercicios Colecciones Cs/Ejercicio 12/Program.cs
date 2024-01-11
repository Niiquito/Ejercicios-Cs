namespace Ejercicio12;
public class Ejercicio12
{
    /*
        Crear una LinkedList de números enteros y, 
        a continuación, realizar las siguientes operaciones:

            Mostrar la LinkedList en consola.
            Insertar un número al principio de la LinkedList.
            Insertar un número al final de la LinkedList.
            Eliminar el primer elemento de la LinkedList.
            Eliminar el último elemento de la LinkedList.
            Mostrar la LinkedList en consola después de realizar las operaciones anteriores.
    */
    static void Main()
    {
        LinkedList<int> numeros = new LinkedList<int>();
        numeros.AddLast(10);
        numeros.AddLast(20);
        numeros.AddLast(30);
        mostrarLista(numeros);
        numeros.AddFirst(5);
        numeros.AddLast(40);
        Console.WriteLine();
        mostrarLista(numeros);
        Console.WriteLine();
        numeros.RemoveFirst();
        numeros.RemoveLast();
        mostrarLista(numeros);
    }

    private static void mostrarLista(LinkedList<int> numeros)
    {
        foreach (int item in numeros)
        {
            Console.WriteLine(item);
        }
    }
}