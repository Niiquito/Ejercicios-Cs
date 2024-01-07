namespace Ejercicio7;
public class Ejercicio7
{
    //7)  Dado un array de números, muestra el mayor y el menor.
    static void Main()
    {
        int[] array1 = { 3, 5, 4, 7, 6, 8, 1, 2,20,50 };
        #region "Forma 1"

        int menor = 9999, mayor = 0;
        for (int i = 0; i < array1.Length; i++)
        {
            if (array1[i] > mayor)
            {
                mayor = array1[i];
            }
            else if (array1[i] < menor)
            {
                menor = array1[i];
            }
        }
        Console.WriteLine(mayor);
        Console.WriteLine(menor);

        #endregion

        Console.WriteLine();

        #region "Forma 2"

        Array.Sort(array1); //Ordena de menor a mayor por default
        menor = array1[0];
        mayor = array1[array1.Length -1];
        Console.WriteLine(menor);
        Console.WriteLine(mayor);

        #endregion
    }
}