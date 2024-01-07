namespace Ejercicio26;
public class Ejercicio26
{
    static void Main()
    {
        Random numeroRandom = new Random();
        int[,] array1 = new int[5, 3];
        int[] maximoFila = new int[array1.GetLength(0)];
        int[] minimoFila = new int[array1.GetLength (0)];
        for (int i = 0; i < minimoFila.Length; i++)
        {
            minimoFila[i] = 9999;
        }
        asignacionRandom(array1, numeroRandom);
        graficoMatriz(array1);
        obtenerMaximoMinimoFila(array1, maximoFila, minimoFila);
        Console.WriteLine("\n");
        mostrarMaximoMinimoFila(maximoFila, minimoFila);
    }

    private static void mostrarMaximoMinimoFila(int[] maximoFila, int[] minimoFila)
    {
        for (int i = 0; i < maximoFila.Length; i++)
            Console.WriteLine($"Maximo y Minimo Fila {i}: {maximoFila[i]}, {minimoFila[i]}");
    }

    private static void obtenerMaximoMinimoFila(int[,] array1, int[] maximoFila, int[] minimoFila)
    {
        for (int i = 0; i < array1.GetLength(0); i++)
            for (int j = 0; j < array1.GetLength(1); j++)
            {
                if (array1[i, j] > maximoFila[i])
                    maximoFila[i] = array1[i, j];
                if (array1[i, j] < minimoFila[i])
                    minimoFila[i] = array1[i, j];
            }
    }

    private static void asignacionRandom(int[,] matriz, Random numeroRandom)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                matriz[i, j] = numeroRandom.Next(1, 10);
            }
    }
    private static void graficoMatriz(int[,] matriz)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}