namespace Ejercicio14;
public class Ejercicio14
{
    static void Main()
    {
        Dictionary<string, int> persona = new Dictionary<string, int>();
        for (int i = 0; i < 3; i++)
        {
            persona.Add(Console.ReadLine(), int.Parse(Console.ReadLine()));
        }
        Console.WriteLine();
        foreach (KeyValuePair<string, int> informacion in persona)
        {
            Console.WriteLine($"Nombre: {informacion.Key}, Edad: {informacion.Value}");
        }
    }
}