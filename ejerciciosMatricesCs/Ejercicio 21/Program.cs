namespace Ejercicio21;
public class Ejercicio21
{
    //Para tener la diagonal, siempre tiene que ser cuadrada la matriz, es decir, tamaño de fila y columna iguales.
    //En la diagonal principal los índices son iguales
    //En la secundaria los índices siempre es la suma de los índices menos el tamaño de la columna.
    static void Main()
    {
        int[,] array1 = new int[4, 4];
        Random numeroRandom = new Random();
        asignacionRandom(array1, numeroRandom);
        graficoMatriz(array1);
        Console.WriteLine("\n\n");
        diagonalPrincipal(array1);
        Console.WriteLine("\n\n");
        diagonalSecundaria(array1);
    }

    private static void diagonalSecundaria(int[,] array1)
    {
        Console.WriteLine("Diagonal secundaria \n");
        for (int i = 0; i < array1.Length; i++)
            for (int j = 0; j < array1.Length; j++)
                if ((i + j) == (array1.GetLength(1) - 1))
                    Console.WriteLine($"Numero en ({i}, {j}): {array1[i, j]}");
    }

    private static void diagonalPrincipal(int[,] array1)
    {
        Console.WriteLine("Diagonal principal \n");
        for (int i = 0; i < array1.GetLength(0); i++)
            for (int j = 0; j < array1.GetLength(1); j++)
                if (i==j)
                    Console.WriteLine($"Numero en ({i}, {j}): {array1[i,j]}");
    }

    private static void graficoMatriz(int[,] array1)
    {
        for (int i = 0; i < array1.GetLength(0); i++)
        {
            for (int j = 0; j < array1.GetLength(1); j++)
            {
                Console.Write(array1[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    private static void asignacionRandom(int[,] array1, Random numeroRandom)
    {
        for (int i = 0; i < array1.GetLength(0); i++)
            for (int j = 0; j < array1.GetLength(1); j++)
            {
                array1[i, j] = numeroRandom.Next(1, 10);
            }
    }
}