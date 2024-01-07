namespace Ejercicio22;
public class Ejercicio22
{
    static void Main()
    {
        int[,] array1 = new int[3, 3];
        int[,] array2 = new int[3, 3];
        int[,] sumaArray = new int[3, 3];
        Random numeroRandom = new Random();
        asignacionRandom(array1, numeroRandom);
        Console.WriteLine("Matriz 1 \n");
        graficoMatriz(array1);
        Console.WriteLine();
        asignacionRandom(array2, numeroRandom);
        Console.WriteLine("Matriz 2 \n");
        graficoMatriz(array2);
        Console.WriteLine();
        Console.WriteLine("Suma de las 2 matrices \n");
        sumaMatriz(array1, array2, sumaArray);
        graficoMatriz(sumaArray);
    }

    private static void sumaMatriz(int[,] array1, int[,] array2, int[,] sumaArray)
    {
        for (int i = 0; i < sumaArray.GetLength(0); i++)
        {
            for (int j = 0; j < sumaArray.GetLength(1); j++)
            {
                sumaArray[i, j] = array1[i, j] + array2[i, j];
            }
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