namespace Ejercicio14;
public class Ejercicio14
{
    static void Main()
    {
        Dictionary<string, int> persona = new Dictionary<string, int>();
        bool continuar = false;
        do
        {
            try
            {
                persona.Add(Console.ReadLine(), int.Parse(Console.ReadLine()));
            }
            catch (Exception e)
            {
                Console.WriteLine("Error, ingrese nuevamente", e);
            }
        } while (!(persona.ContainsKey("") && persona.ContainsValue(0)));
        Console.WriteLine();
        int cero = 0;
        persona.Remove<string, int>("", out cero);
        foreach (KeyValuePair<string, int> informacion in persona)
        {
            Console.WriteLine($"Nombre: {informacion.Key}, Edad: {informacion.Value}");
        }
    }
}