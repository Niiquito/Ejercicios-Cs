namespace Ejercicio2;
public class Ejercicio2
{
    /*Crear una lista de números enteros y, a continuación, 
     * realizar las siguientes operaciones:

        Mostrar la lista en consola.
        Encontrar el número mayor y el número menor de la lista.
        Obtener la suma de todos los números de la lista.
        Obtener el promedio de todos los números de la lista.
    */
    static void Main()
    {
        List<int> numeros = new List<int>();
        for (int i = 0; i < 3; i++)
        {
            numeros.Add(int.Parse(Console.ReadLine()));
        }
        Console.WriteLine();
        int suma = 0, mayor = 0, menor = 999;
        foreach (int item in numeros)
        {
            Console.WriteLine(item);
            suma += item ;
            if (item > mayor)
                mayor = item;
            if (item < menor)
                menor = item;
        }
        Console.WriteLine($"Suma de los elementos de la lista: {suma} \n" +
            $"Promedio: {suma / numeros.Count} \n" +
            $"Mayor: {mayor} \n" +
            $"Menor: {menor}");
    }
}