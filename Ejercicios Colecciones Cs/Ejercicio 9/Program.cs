﻿namespace Ejercicio9;
public class Ejercicio9
{
    /*
         Crear una lista de palabras y, a continuación,
         realizar las siguientes operaciones:

            Mostrar la lista en consola.
            Contar la cantidad de palabras que comienzan con la letra "a".
            Contar la cantidad de palabras que tienen más de 5 letras.
            Mostrar en consola las palabras que comienzan con la letra "a" 
            y tienen más de 5 letras.
    */
    static void Main()
    {
        List<string> palabras = new List<string>();
        int contadorCaracter = 0, contadorPalabras = 0;
        ingresarElementos(palabras);
        List<string> palabrasMayoresConA = new List<string>();
        mostrarElementos(palabras);
        contadores(palabras, ref contadorCaracter, ref contadorPalabras, palabrasMayoresConA);
        Console.WriteLine($"\nCantidad de palabras con longitud mayor a 5: {contadorPalabras} \n" +
            $"Cantidad de palabras que empiezan con 'A': {contadorCaracter}\n");
        foreach (string item in palabrasMayoresConA)
            Console.WriteLine($"Palabras con longitud mayor a 5 y empiezan con A: {item}");
    }

    private static void contadores(List<string> palabras, ref int contadorCaracter, ref int contadorPalabras, List<string> palabrasMayoresConA)
    {
        foreach (string item in palabras)
        {
            if (item.Length > 5)
                contadorPalabras++;
            if (item.StartsWith("a") || item.StartsWith("A"))
                contadorCaracter++;
            if (item.Length > 5 && (item.StartsWith("a") || item.StartsWith("A")))
                palabrasMayoresConA.Add(item);
        }
    }

    private static void mostrarElementos(List<string> palabras)
    {
        foreach (string item in palabras)
            Console.WriteLine(item);
    }

    private static void ingresarElementos(List<string> palabras)
    {
        do
        {
            try
            {
                palabras.Add(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Error, ingrese nuevamente");
            }
        } while (!palabras.Contains(""));
    }
}