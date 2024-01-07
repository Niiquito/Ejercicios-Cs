namespace Ejercicio29;
public class Ejercicio29
{
    static void Main()
    {
        int[,] array1 = new int[3, 3]
        {
            {1,0,0 },
            {0,2,0 },
            {0,0,3 }
        };
        int suma = 0;
        graficoMatriz(array1);
        suma = obtenerDiagonal(array1, suma);
        if (suma > 0)
            Console.WriteLine($"No es matriz diagonal");
        else
            Console.WriteLine("Es matriz diagonal");
    }

    private static int obtenerDiagonal(int[,] array1, int suma)
    {
        for (int i = 0; i < array1.GetLength(0); i++)
            for (int j = 0; j < array1.GetLength(1); j++)
                if ((i != j))
                    suma += array1[i, j];
        return suma;
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