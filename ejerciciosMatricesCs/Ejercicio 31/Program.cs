namespace Ejercicio31;
public class Ejercicio31
{
    static void Main()
    {
        Random numeroRandom = new Random();
        int[,] array1 = new int[3, 3];
        asignacionRandom(array1,numeroRandom);
        graficoMatriz(array1);
        for (int i = 0; i < array1.GetLength(0); i++)
        {
            for (int j = 0; j < array1.GetLength(1); j++)
            {
                if (i==j)
                {
                    array1[i, j] = 1;
                }
                else
                {
                    array1[i,j] = 0;
                }
            }
        }
        Console.WriteLine();
        graficoMatriz(array1);
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