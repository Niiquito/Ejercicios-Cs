namespace Ejercicio9;
public class Ejercicio9
{
    //Crear un array de n elementos que permita ingresar solamente múltiplos de 5.
    static void Main()
    {
        Console.Write("Ingrese el tamaño del array: ");
        int tamanioArray = Convert.ToInt16(Console.ReadLine());
        int[] array1 = new int[tamanioArray];
        int contador = 0;
        do
        {
        Console.Write("Ingrese un número múltiplo de 5: ");
        int numero = Convert.ToInt32(Console.ReadLine());
            if (numero % 5 == 0)
            {
                array1[contador] = numero;
                contador++;
            }
            else
                Console.WriteLine("Incorrecto");
        } while (contador < tamanioArray);
        for (int i = 0; i < array1.Length; i++)
            Console.WriteLine(array1[i]);
    }
}