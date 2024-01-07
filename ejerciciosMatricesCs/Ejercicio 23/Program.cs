namespace Ejercicio23;
public class Ejercicio23
{
    static void Main()
    {
        int[,] array1 = new int[3, 3];
        int[,] arrayParImpar = new int[3, 3];
        Random numeroRandom = new Random();
        asignacionRandom(array1, numeroRandom);
        graficoMatriz(array1);
        obtenerParImpar(array1, arrayParImpar);
        Console.WriteLine("\n");
        graficoMatriz(arrayParImpar);
    }

    private static void obtenerParImpar(int[,] array1, int[,] arrayParImpar)
    {
        for (int i = 0; i < arrayParImpar.GetLength(0); i++)
            for (int j = 0; j < arrayParImpar.GetLength(1); j++)
                if (array1[i, j] % 2 == 0)
                    arrayParImpar[i, j] = 0;
                else
                    arrayParImpar[i, j] = 1;
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