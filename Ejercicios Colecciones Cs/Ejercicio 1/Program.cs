namespace Ejercicio1;
public class Ejercicio1
{
    static void Main()
    {
        LinkedList<int> numeros = new LinkedList<int>();
        foreach (int numero in new int[] {1,2,3,4})
            numeros.AddFirst(numero);
        foreach (int numero in numeros)
            Console.WriteLine(numero);
        Console.WriteLine();
    }
}