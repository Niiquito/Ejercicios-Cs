namespace Ejercicio20;
public class Ejercicio20
{
    static void Main()
    {
        Console.Write("Ingrese la cantidad de filas de la matriz:  ");
        int fila = int.Parse(Console.ReadLine());
        Console.Write("Ingrese la cantidad de columnas de la matriz: ");
        int columna = int.Parse(Console.ReadLine());
        int[,] array1 = new int[fila, columna];
        Random numeroRandom = new Random();
        int[] maximoHorizontal = new int[fila];
        int[] maximoVertical = new int[columna];
        int[] suma = new int[fila];
        asignacionRandom(array1, numeroRandom);
        Console.WriteLine("Matriz original");
        graficoMatriz(array1);
        for (int i = 0; i < array1.GetLength(0); i++)
        {
            for (int j = 0; j < array1.GetLength(1); j++)
            {
                suma[i] += array1[i, j];
                if (array1[i, j] > maximoHorizontal[i])
                    maximoHorizontal[i] = array1[i, j];
                if (array1[i, j] > maximoVertical[j])
                    maximoVertical[j] = array1[i, j];
            }
            Console.WriteLine();
        }
        maxFila(array1, maximoHorizontal);
        Console.WriteLine();
        maxColumna(array1, maximoVertical);
        Console.WriteLine();
        for (int i = 0; i < array1.GetLength(0); i++)
        {
            Console.WriteLine($"Suma Fila {i + 1}: {suma[i]}");
        }
    }

    private static void asignacionRandom(int[,] array1, Random numeroRandom)
    {
        for (int i = 0; i < array1.GetLength(0); i++)
            for (int j = 0; j < array1.GetLength(1); j++)
            {
                array1[i, j] = numeroRandom.Next(1, 100);
            }
    }

    private static void maxColumna(int[,] array1, int[] maximoVertical)
    {
        for (int i = 0; i < array1.GetLength(1); i++)
            Console.WriteLine($"Columna Vertical {i + 1}, Maximo {maximoVertical[i]} \t");
    }

    private static void maxFila(int[,] array1, int[] maximoHorizontal)
    {
        for (int i = 0; i < array1.GetLength(0); i++)
            Console.WriteLine($"Fila Horizontal {i + 1}, Maximo {maximoHorizontal[i]} \t");
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
}