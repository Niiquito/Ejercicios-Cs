namespace Ejercicio28;
public class Ejercicio28
{
    static void Main()
    {
        Random numeroRandom = new Random();
        int[,] array1 = new int[3, 3];
        int[,] transpuesta = new int[3, 3];
        asignacionRandom(array1, numeroRandom);
        graficoMatriz(array1);
        obtenerTranspuesta(array1, transpuesta);
        Console.WriteLine();
        graficoMatriz(transpuesta);
        if (array1.Length == transpuesta.Length)
        {
            Console.WriteLine("\nLa matriz es simétrica");
        }
    }

    private static void obtenerTranspuesta(int[,] array1, int[,] transpuesta)
    {
        for (int i = 0; i < transpuesta.GetLength(0); i++)
            for (int j = 0; j < transpuesta.GetLength(1); j++)
                transpuesta[i, j] = array1[j, i];
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
