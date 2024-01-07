namespace Ejercicio33;
public class Ejercicio33
{
    static void Main()
    {
        List<int> numeros = new List<int>();
        int numero = 1;
        Console.WriteLine("Ingrese numeros");
        do
        {
            numero = int.Parse(Console.ReadLine());
            numeros.Add(numero);
        } while (numero !=0);
        Console.WriteLine();
        numeros.RemoveAt(numeros.Count - 1);
        foreach (int elemento in numeros)
        {
            Console.WriteLine(elemento);
        }
    }
}