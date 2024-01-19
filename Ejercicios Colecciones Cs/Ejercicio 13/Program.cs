namespace Ejercicio13;
public class Ejercicio13
{
    /*
         Escribe un programa en C# que implemente una cola usando una lista. 
         La cola debe tener métodos para encolar, desencolar, 
         consultar el primer elemento y obtener el tamaño. 
         Además, el programa debe mostrar el contenido de la cola después de cada operación.
    */
    static void Main()
    {
        LinkedList<string> palabras = new LinkedList<string>();
        Queue<string> cola = new Queue<string>();
        try
        {
            Console.WriteLine("Ingrese palabras");
            ingresarDatos(cola);
            Console.WriteLine($"El primer elemento es: {cola.Peek()}, la lista tiene un tamaño de: {cola.Count - 1}");
            int tamañoCola = cola.Count;
            eliminarCola(cola, tamañoCola);
            Console.WriteLine($"\nLa lista luego del Dequeue tiene un tamaño de: {cola.Count}");
        }
        catch (Exception e)
        {
            Console.WriteLine("Error");
        }
    }

    private static void ingresarDatos(Queue<string> cola)
    {
        do
        {
            cola.Enqueue(Console.ReadLine());
            cola.ToList();
            Console.WriteLine($"La palabra ingresada es '{cola.Last()}'.\n");
        } while (!cola.Contains(""));
    }

    private static void eliminarCola(Queue<string> cola, int tamañoCola)
    {
        for (int i = 0; i < tamañoCola; i++)
            cola.Dequeue();
    }
}