namespace Ejercicio18;
public class Ejercicio18
{
    //Realice un programa que inicialice una matriz de 2 filas por 3 columnas con valores enteros
    //y calcule el cuadrado de cada elemento de esta.Imprimir la matriz original y la resultante.
    static void Main()
    {
        double[,] array1 = new double[2, 3];
        Random rnd = new Random();
        Console.WriteLine();
        for (int i = 0; i < array1.GetLength(0); i++)
        {
            for (int j = 0; j < array1.GetLength(1); j++)
            {
                array1[i, j] = rnd.Next(1,10);
            }
        }
        Console.WriteLine("Matriz original");
        graficoMatriz(array1);
        for (int i = 0; i < array1.GetLength(0); i++)
        {
            for (int j = 0; j < array1.GetLength(1); j++)
            {
                array1[i, j] = Math.Pow(array1[i, j], 2); 
            }
        }
        Console.WriteLine();
        Console.WriteLine("Matriz cuadrada");
        graficoMatriz(array1);
    }

    private static void graficoMatriz(double[,] array1)
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