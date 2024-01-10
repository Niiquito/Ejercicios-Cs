namespace Ejercicio10;
public class Ejercicio10
{
    /* 
        Crear una lista de números enteros y, a continuación, realizar las siguientes operaciones:

            Mostrar la lista en consola.
            Ordenar la lista de menor a mayor.
            Dividir la lista en dos sublistas, una con los números pares y otra con los números impares.
            Mostrar en consola cada sublista.
    */
    static void Main()
    {
        List<int> numeros = new List<int>();
        List<int> numerosPares = new List<int>();
        List<int> numerosImpares = new List<int>();
        numeros.Add(10);
        numeros.Add(20);
        numeros.Add(15);
        numeros.Add(50);
        numeros.Add(33);
        foreach (int item in numeros)
            Console.WriteLine(item);
        numeros.Sort();
        foreach (int item in numeros)
        {
            if (item % 2 == 0)
                numerosPares.Add(item);
            else
                numerosImpares.Add(item);
        }
        Console.WriteLine("\n Numeros pares");
        foreach (int item in numerosPares)
            Console.WriteLine(item);
        Console.WriteLine("\n Numeros impares");
        foreach (int item in numerosImpares)
            Console.WriteLine(item);
    }
}