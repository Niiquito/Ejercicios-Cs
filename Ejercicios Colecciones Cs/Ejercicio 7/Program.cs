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
        numeros.Add(10);
        numeros.Add(20);
        numeros.Add(30);
        numeros.Add(40);
        numeros.Add(60);
        numeros.Add(70);
        foreach (int item in numeros)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
        for (int i = 0; i < numeros.Count - 1; i++)
        {
            diferencia = numeros[i + 1] - numeros[i];
            if (diferencia > MayorDiferencia)
            {
                MayorDiferencia = diferencia;
            }
        }
            Console.WriteLine($"La mayor diferencia es: { MayorDiferencia}");
    }
}