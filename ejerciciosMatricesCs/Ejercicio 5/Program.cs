namespace Ejercicio5;
public class Ejercicio5
{
    //5) Pedir un numero por teclado y
    //multiplicar todos los valores de un array y mostrar el array.
    static void Main()
    {
        #region "Forma 1"
        int[] array1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int multiplicacionArray = 1;
        for (int i = 0; i < array1.Length; i++)
        {
            multiplicacionArray *= array1[i];
        }
        Console.WriteLine("La multiplicacion es: " + multiplicacionArray / array1.Length);
        #endregion
        #region "Forma 2"
        for (int i = 0; i < array1.Length; i++)
        {
            Console.WriteLine($"La multiplicación de la posición {i} por el valor {array1[i]} es: {i * array1[i]}");
        }
        #endregion
    }
}