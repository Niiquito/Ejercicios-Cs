namespace Ejercicio4;
public class Ejercicio4
{
    //4) Hacer la media de los valores de un array y mostrar el resultado.
    static void Main()
    {
        int[] array1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int sumaArray = 0;
        for (int i = 0; i < array1.Length; i++)
        {
            sumaArray += array1[i];
        }
        Console.WriteLine("La media es: " + sumaArray / array1.Length);
    }
}