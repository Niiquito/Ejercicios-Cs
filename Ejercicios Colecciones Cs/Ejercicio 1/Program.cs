namespace Ejercicio1;
public class Ejercicio1
{
    static void Main()
    {
        LinkedList<int> numeros = new LinkedList<int>();
        agregarElementos(numeros);
        numeros.Remove(0);
        Console.WriteLine();
        mostrarElementos(numeros);
        Console.WriteLine();
    }

    private static void mostrarElementos(LinkedList<int> numeros)
    {
        foreach (int numero in numeros)
            Console.Write(numero + " ");
    }

    private static void agregarElementos(LinkedList<int> numeros)
    {
        do
        {
            try
            {
                numeros.AddFirst(int.Parse(Console.ReadLine()));
            }
            catch (Exception e)
            {
                Console.WriteLine("Elemento inválido, ingrese nuevamente");
            }
        } while (!numeros.Contains(0));
    }
}