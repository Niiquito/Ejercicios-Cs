namespace Ejercicio15;
public class Ejercicio15
{
       struct Usuario
    {
        public string nombre;
        public int edad;
    }
    static void Main()
    {
        Usuario persona = new Usuario();
        Console.Write("Ingrese el nombre: ");
        persona.nombre = Console.ReadLine();
        Console.Write("Ingrese la edad: ");
        persona.edad = int.Parse(Console.ReadLine());
        Console.WriteLine($"Nombre: {persona.nombre} \n" +
            $"Edad: {persona.edad}");
    }
}