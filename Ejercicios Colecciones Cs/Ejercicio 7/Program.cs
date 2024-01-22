namespace Ejercicio7;
public class Ejercicio7
{
    /*
        Crear una lista de números enteros y, a continuación, 
        realizar las siguientes operaciones:

            Mostrar la lista en consola.
            Encontrar la mayor diferencia entre dos números consecutivos de la lista.
    */
    static void Main()
    {
        List<int> numeros = new List<int>();
        int diferencia = 0, MayorDiferencia = -1;
        agregarNumeros(numeros);
        numeros.Remove(0);
        Console.WriteLine();
        mostrarElementos(numeros);
        Console.WriteLine();
        encontrarDiferencia(numeros, ref diferencia, ref MayorDiferencia);
        Console.WriteLine($"La mayor diferencia es: { MayorDiferencia}");
    }

    private static void encontrarDiferencia(List<int> numeros, ref int diferencia, ref int MayorDiferencia)
    {
        for (int i = 0; i < numeros.Count - 1; i++)
        {
            diferencia = numeros[i + 1] - numeros[i];
            if (diferencia > MayorDiferencia)
                MayorDiferencia = diferencia;
        }
    }

    private static void mostrarElementos(List<int> numeros)
    {
        foreach (int item in numeros)
            Console.WriteLine(item);
    }

    private static void agregarNumeros(List<int> numeros)
    {
        do
        {
            try
            {
                numeros.Add(int.Parse(Console.ReadLine()));
            }
            catch (Exception e)
            {
                Console.WriteLine("Error, ingrese nuevamente", e);
            }
        } while (!numeros.Contains(0));
    }
}