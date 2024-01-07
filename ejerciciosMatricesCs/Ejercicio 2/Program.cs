namespace Ejercicio2;
public class Ejercicio2
{
    //2) Crea un array de 10 posiciones, pide los valores por consola y muestra el array.
    static void Main()
    {
        int[] array1 = new int[10];
        for (int i = 0; i < array1.Length; i++)
        {
            Console.Write($"Ingrese un valor en la posición {i}: ");
            array1[i] = Convert.ToInt16(Console.ReadLine());
        }
        for (int i = 0; i < array1.Length; i++)
        {
            Console.WriteLine($"Valor en posición {i}: {array1[i]}");
        }
    }
}