namespace Ejercicio6;
public class Ejercicio6
{
    //6) Dado un array de numeros con el metodo Sort, ordenalos y muestra su contenido.
    static void Main()
    {
        int[] array1 = { 3,5,4,7,6,8,1,2};
        for (int i = 0; i < array1.Length; i++)
        {
            Console.WriteLine(array1[i]);
        }
        Console.WriteLine();
        Array.Sort(array1);
        for (int i = 0; i < array1.Length; i++)
        {
            Console.WriteLine(array1[i]);
        }
    }
}