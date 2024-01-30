namespace Ejercicio15;
public class Ejercicio15
{
    static void Main()
    {
        Queue<string> cola = new Queue<string>();
        LinkedList<string> lista = new LinkedList<string>();
        ingresarPalabras(lista);
        Console.WriteLine();
        lista.RemoveLast();
        Console.WriteLine("Mostrar elementos \n");
        mostrarLista(lista);
        Console.WriteLine("\nMostrar elementos en cola");
        ponerElementosEnCola(cola, lista);
        Console.WriteLine();
        mostrarCola(cola);
        Console.WriteLine($"\nPrimer elemento: {cola.Peek()}");
        Console.WriteLine("\nCola eliminada con Enqueue");
        quitarElementosDeCola(cola);
        mostrarCola(cola);
    }

    private static void ingresarPalabras(LinkedList<string> lista)
    {
        do
        {
            try
            {
                lista.AddLast(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Valor incorrecto, ingrese nuevamente", e);
            }
        } while (!lista.Contains(""));
    }

    private static void mostrarLista(LinkedList<string> lista)
    {
        foreach (string item in lista)
            Console.WriteLine(item);
    }

    private static void quitarElementosDeCola(Queue<string> cola)
    {
        int tamañoCola = cola.Count;
        for (int i = 0; i < tamañoCola; i++)
            cola.Dequeue();
    }

    private static void ponerElementosEnCola(Queue<string> cola, LinkedList<string> lista)
    {
        foreach (string item in lista)
            cola.Enqueue(item);
    }

    private static void mostrarCola(Queue<string> cola)
    {
        foreach (string item in cola)
            Console.WriteLine(item);
    }
}