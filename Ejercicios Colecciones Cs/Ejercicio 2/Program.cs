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
            agregarElementos(numeros);
            numeros.Remove(0);
            Console.WriteLine();
            int suma = 0, mayor = 0, menor = 999;
            mayorMenor(numeros, ref suma, ref mayor, ref menor);
            Informe(numeros, suma, mayor, menor);

    }

    private static void Informe(List<int> numeros, int suma, int mayor, int menor)
    {
        Console.WriteLine($"Suma de los elementos de la lista: {suma} \n" +
                    $"Promedio: {suma / numeros.Count} \n" +
                    $"Mayor: {mayor} \n" +
                    $"Menor: {menor}");
    }

    private static void mayorMenor(List<int> numeros, ref int suma, ref int mayor, ref int menor)
    {
        foreach (int item in numeros)
        {
            Console.WriteLine(item);
            suma += item;
            if (item > mayor)
                mayor = item;
            if (item < menor)
                menor = item;
        }
    }

    private static void agregarElementos(List<int> numeros)
    {
        do
        {
            try
            {
                numeros.Add(int.Parse(Console.ReadLine()));
            }
            catch (Exception e)
            {
                Console.WriteLine("Valor incorrecto, ingrese nuevamente", e);
            }
        } while (!numeros.Contains(0));
    }
}