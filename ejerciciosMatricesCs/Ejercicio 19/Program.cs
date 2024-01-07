namespace Ejercicio19;
public class Ejercicio19
{
    static void Main()
    {
        Console.Write("Ingrese la cantidad de filas de la matriz:  ");
        int fila = int.Parse(Console.ReadLine());
        Console.Write("Ingrese la cantidad de columnas de la matriz: ");
        int columna = int.Parse(Console.ReadLine());    
        int[,] array1 = new int[fila,columna];
        Random numeroRandom = new Random();
        int maximo = 0;
        for (int i = 0; i < array1.GetLength(0); i++)
            for (int j = 0; j < array1.GetLength(1); j++)
            {
                array1[i, j] = numeroRandom.Next(1, 100);
            }
        Console.WriteLine("Matriz original");
        graficoMatriz(array1);
        Console.Write("Ingrese el numero de una fila: ");
        int numeroFila = int.Parse(Console.ReadLine());
        for (int i = numeroFila - 1; i < numeroFila; i++)
        {
            for (int j = 0; j < array1.GetLength(1); j++)
            {
                if (array1[i, j] > maximo)
                    maximo = array1[i, j];
                Console.Write(array1[i, j] + "\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine(maximo);
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