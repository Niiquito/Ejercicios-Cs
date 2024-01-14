namespace Ejercicio15;
public class Ejercicio15
{
    static void Main()
    {
        Queue<string> cola = new Queue<string>();
        LinkedList<string> lista = new LinkedList<string>();
        string palabra = "a";
        try
        {
            palabra = ingresarPalabras(lista);
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
        catch (Exception e)
        {
            Console.WriteLine("Error", e);
            throw;
        }
    }

    private static string ingresarPalabras(LinkedList<string> lista)
    {
        string palabra;
        do
        {
            try
            {
                palabra = Console.ReadLine();
                lista.AddLast(palabra);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error", e);
                throw;
            }
        } while (palabra != "");
        return palabra;
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