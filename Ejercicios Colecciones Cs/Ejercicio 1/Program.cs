namespace Ejercicio1;
public class Ejercicio1
{
    static void Main()
    {
        LinkedList<int> numeros = new LinkedList<int>();
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
        numeros.Remove(0);
        Console.WriteLine();
        foreach (int numero in numeros)
            Console.Write(numero + " ");
        Console.WriteLine();
    }
}