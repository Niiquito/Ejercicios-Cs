using LibreriaObjetos1;

static class Ejercicio1
{
    static void Main()
    {
        Customer persona = new Customer();
        List<string> nombre = new List<string>();
        List<int> dni = new List<int>();
        List<DateTime> fechaNacimiento = new List<DateTime>();
        Console.WriteLine("Ingrese nombre, DNI y fecha de nacimiento");
        do
        {
            Console.Write("Nombre: ");
            persona.Name = Console.ReadLine();
            if (persona.Name == "")
                break;
            else
            {
                Console.Write("DNI:");
                persona.dni = int.Parse(Console.ReadLine());
                Console.Write("Fecha de nacimiento: ");
                persona.BirthDay = DateTime.Parse(Console.ReadLine());
                nombre.Add(persona.Name);
                dni.Add(persona.dni);
                fechaNacimiento.Add(persona.BirthDay);
            }
        } while (persona.Name != "");
        Console.ReadKey();
        Console.Clear();

        for (int i = 0; i < nombre.Count; i++)
            Console.Write($"Nombre: {nombre[i]}\n" +
                $"DNI: {dni[i]}\n" +
                $"Fecha Nacimiento: {fechaNacimiento[i]}\n");
    }
}