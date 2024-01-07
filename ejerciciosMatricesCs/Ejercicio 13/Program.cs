namespace Ejercicio13;
public class Ejercicio13
{
    static void Main()
    {
        int[] array1 = new int[] {5,4,3,2,1,2,5};
        int auxiliar = 0;
        for (int i = 0; i < array1.Length -1; i++)
        {
            for (int j = 0; j < array1.Length - 1; j++)
            {
                if (array1[j] > array1[j+1])
                {
                    //auxiliar guarda el elemento sobre el que array1 (pos 0 = 5) está parado
                    auxiliar = array1[j];
                    //array1 (pos 0 = 5) será igual a array1++ (pos 1 = 4), es decir, a la siguiente posición
                    array1[j] = array1[j+1];
                    //array1++ (pos 1 = 4), es decir, la posición siguiente será igual al elemento que tiene
                    //array1 (pos 0 = 5)
                    //5,4,3,2,1: 5 = pos 0, 4 = pos 1.
                    array1[j+1] = auxiliar;
                }
            }
        }
        for (int i = 0; i < array1.Length; i++)
        {
            Console.WriteLine(array1[i]);
        }
        Console.WriteLine();
        for (int i = array1.Length - 1;  i >= 0;  i--)
        {
            Console.WriteLine(array1[i]);
        }

    }
}