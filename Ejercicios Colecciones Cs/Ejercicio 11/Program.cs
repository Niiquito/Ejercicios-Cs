﻿namespace Ejercicio11;
public class Ejercicio11
{
    /*
        Crear una lista de números enteros y, a continuación, 
        realizar las siguientes operaciones:

            Mostrar la lista en consola.
            Encontrar el número más grande de la lista.
            Encontrar la posición del número más grande en la lista.
            Eliminar el número más grande de la lista.
            Mostrar la lista en consola sin el número más grande.
    */
    static void Main()
    {
        List<int> numeros = new List<int>();
        int mayor = 0, posicion = 0;
        agregarElementos(numeros);
        numeros.Remove(0);
        mostrarLista(numeros);
        obtenerMayorConPosicion(numeros, ref mayor, ref posicion);
        Console.WriteLine($"\nEl numero mayor es: {mayor} \n" +
            $"Está en la posición: {posicion + 1}");
        numeros.Remove(mayor);
        Console.WriteLine("\nLista sin el numero mayor\n");
        mostrarLista(numeros);
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
                    Console.WriteLine("Dato inválido, ingrese nuevamente", e);
                }
            } while (!numeros.Contains(0));
    }


    private static void obtenerMayorConPosicion(List<int> numeros, ref int mayor, ref int posicion)
    {
        for (int i = 0; i < numeros.Count; i++)
            if (numeros[i] > mayor)
            {
                mayor = numeros[i];
                posicion = i;
            }
    }

    private static void mostrarLista(List<int> numeros)
    {
        foreach (int item in numeros)
            Console.WriteLine(item);
    }
}