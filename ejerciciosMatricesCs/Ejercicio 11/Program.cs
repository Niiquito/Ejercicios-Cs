namespace Ejercicio11;
public class Ejercicio11
{
    static void Main()
    {
        Console.WriteLine("Ingrese 5 numeros enteros");
        Console.WriteLine();
        int[,] matrix = new int[1,5];
        for (int i = 0; i < 1; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                matrix[i,j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        // i = fila = ir para abajo
        // j = columna = ir a la derecha
        Console.WriteLine();
        for (int i = 0; i < 1; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write(matrix[i, j]);
            }
            Console.WriteLine();
        }
    }
}