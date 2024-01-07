namespace Ejercicio14;
public class Ejercicio14
{
    static void Main()
    {
        string[,] arrayCaracteres = new string[20, 70];
        for (int i = 0; i < arrayCaracteres.GetLength(0); i++)
            for (int j = 0; j < arrayCaracteres.GetLength(1); j++)
            {
                arrayCaracteres[i, j] = "X";
            }
        Console.WriteLine();
        for (int i = 0; i < arrayCaracteres.GetLength(0); i++)
        { 
            for (int j = 0; j < arrayCaracteres.GetLength(1); j++)
            {
                Console.Write(arrayCaracteres[i, j]);
            }
            Console.WriteLine();
        }
            
    }
}