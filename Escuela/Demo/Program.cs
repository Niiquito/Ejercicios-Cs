using Entities;
public class Demo
{
    static void Main()
    {
        Libro libro0 = new Libro(0, "Principito", "Pepe", 12);
        mostrarLibro(libro0);
        Empleado empleado0 = new Empleado(12, "Pepe", "Peronio 5126", 376451252);
        mostrarEmpleado(empleado0);
    }

    private static void mostrarLibro(Libro libro)
    {
        Console.WriteLine($"ID: {libro.Id}\n" +
                    $"Nombre: {libro.Title}\n" +
                    $"Autor: {libro.Author}\n" +
                    $"Páginas: {libro.numPage}\n");
    }
    private static void mostrarEmpleado(Empleado empleado)
    {
        Console.WriteLine($"CI: {empleado.Ci}\n" +
            $"Nombre: {empleado.Name}\n" +
            $"Dirección: {empleado.Address}\n" +
            $"Celular: {empleado.phoneNumber}\n");
    }
}