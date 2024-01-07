namespace Ejercicio32;
public class Ejercicio32
{
    static void Main()
    {
        Random numeroRandom = new Random();
        int[,] array1 = new int[3, 3];
        int contadorCero = 0, positivo = 0, negativo = 0;
        asignacionRandom(array1, numeroRandom);
        graficoMatriz(array1);
        obtenerCeroPositivoNegativo(array1, ref contadorCero, ref positivo, ref negativo);
        informe(contadorCero, positivo, negativo);
    }

    private static void obtenerCeroPositivoNegativo(int[,] array1, ref int contadorCero, ref int positivo, ref int negativo)
    {
        for (int i = 0; i < array1.GetLength(0); i++)
        {
            for (int j = 0; j < array1.GetLength(1); j++)
            {
                if (array1[i, j] == 0)
                    contadorCero++;
                if (array1[i, j] > 0)
                    positivo++;
                else if (array1[i, j] < 0)
                    negativo++;
            }
        }
    }

    private static void informe(int contadorCero, int positivo, int negativo)
    {
        Console.WriteLine($"Cantidad ceros: {contadorCero}\n" +
                    $"Cantidad positivos: {positivo}\n" +
                    $"Cantidad negativos: {negativo}\n");
    }

    private static void asignacionRandom(int[,] matriz, Random numeroRandom)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                matriz[i, j] = numeroRandom.Next(-2, 4);
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