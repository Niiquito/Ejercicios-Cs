namespace Ejercicio30;
public class Ejercicio30
{
    static void Main()
    {
        int[,] array1 = new int[3, 3]
        {
            {1,0,0 },
            {0,1,0 },
            {0,0,1 }
        };
        graficoMatriz(array1);
        Console.WriteLine();
        int multiplicacion = 1, suma = 0;
        obtenerIdentidad(array1, ref multiplicacion, ref suma);
        comprobarIdentidad(multiplicacion, suma);
    }

    private static void obtenerIdentidad(int[,] array1, ref int multiplicacion, ref int suma)
    {
        for (int i = 0; i < array1.GetLength(0); i++)
            for (int j = 0; j < array1.GetLength(1); j++)
            {
                if (i == j)
                    multiplicacion *= array1[i, j];
                else
                    suma += array1[i, j];
            }
    }

    private static void comprobarIdentidad(int multiplicacion, int suma)
    {
        if (multiplicacion == 1 && suma == 0)
            Console.WriteLine("La matriz es identidad");
        else
            Console.WriteLine("La matriz no es identidad");
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