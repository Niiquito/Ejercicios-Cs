namespace Ejercicio1;
public class Ejercicio1
{
    //1) Crea un array de 10 posiciones, con valores puestos por ti y muestra el array.
    static void Main()
    {
        int[] array1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        for (int i = 0; i < array1.Length; i++)
        {
            Console.WriteLine($"{array1[i]}");
        }
    }
}