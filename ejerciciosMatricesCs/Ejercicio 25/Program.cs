namespace Ejercicio25;
    public class Ejercicio25
{
    //Sumar cada una de las columnas de la matriz e imprimirla
    static void Main()
    {
        Random numeroRandom = new Random();
        int[,] array1 = new int[3, 3];
        int[] sumaColumna = new int[array1.GetLength(1)];
        asignacionRandom(array1, numeroRandom);
        graficoMatriz(array1);
        sumarColumna(array1, sumaColumna);
        Console.WriteLine("\n");
        for (int i = 0; i < array1.GetLength(1); i++)
        {
            Console.WriteLine($"Suma columna {i}: {sumaColumna[i]}");
        }
    }

    private static void sumarColumna(int[,] array1, int[] sumaColumna)
    {
        for (int i = 0; i < array1.GetLength(0); i++)
        {
            for (int j = 0; j < array1.GetLength(1); j++)
            {
                sumaColumna[j] += array1[i, j];
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