﻿namespace Ejercicio14;
public class Ejercicio14
{
    static void Main()
    {
        Dictionary<string, int> persona = new Dictionary<string, int>();
        int a = 0;
        do
        {
            try
            {
                Console.WriteLine("Nombre y Clave, 0 0: Salir");
                persona.Add(Console.ReadLine(), int.Parse(Console.ReadLine()));
            }
            catch (Exception e)
            {
                Console.WriteLine("Error, ingrese nuevamente", e);
            }
        } while (!(persona.ContainsKey("0") && persona.ContainsValue(0)));
        Console.WriteLine();
        int cero = 0;
        persona.Remove<string, int>("0", out cero);
        foreach (KeyValuePair<string, int> informacion in persona)
            Console.WriteLine($"Nombre: {informacion.Key}, Edad: {informacion.Value}");
    }
}