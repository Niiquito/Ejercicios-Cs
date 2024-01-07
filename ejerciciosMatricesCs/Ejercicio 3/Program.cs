namespace Ejercicio3;
public class Ejercicio3
{
    //3) Sumar los valores de un array y mostrar el resultado.
    static void Main()
    {
        int[] array1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int sumaArray = 0;
        for (int i = 0; i < array1.Length; i++)
        {
            sumaArray += array1[i]; 
        }
        Console.WriteLine("La suma es: " + sumaArray);
    }
}