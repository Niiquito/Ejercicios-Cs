namespace Ejercicio24;
public class Ejercicio24
{
    static void Main()
    {
        int[,] array1 = new int[3, 3];
        int par = 0, impar = 1;
        Random numeroRandom = new Random();
        asignacionRandom(array1, numeroRandom);
        graficoMatriz(array1);
        asginaParImpar(array1, ref par, ref impar);
        Console.WriteLine($"\n Par: {par}" +
            $"\n Impar: {impar}");
    }

    private static void asginaParImpar(int[,] array1, ref int par, ref int impar)
    {
        for (int i = 0; i < array1.GetLength(0); i++)
            for (int j = 0; j < array1.GetLength(1); j++)
                if (array1[i, j] % 2 == 0)
                    par += array1[i, j];
                else
                    impar *= array1[i, j];
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