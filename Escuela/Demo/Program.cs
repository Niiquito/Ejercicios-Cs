using Entities;
public class Demo
{
    static void Main()
    {
        Libro libro0 = new Libro(0, "Principito", "Pepe", 12);
        mostrarLibro(libro0);
        Empleado empleado0 = new Empleado(115, "Pepe", "Peronio 5126", 376451252, 3000);
        mostrarEmpleado(empleado0);
        Empleado empleado1 = new Empleado(120, "Pedro", "Peronio 2126", 376451352, 4000);
        mostrarEmpleado(empleado1);
        Estudiante estudiante0 = new Estudiante(160, "Pato", "M", new DateTime(2022, 12, 12));
        mostrarEstudiante(estudiante0);
    }

    private static void mostrarEstudiante(Estudiante estudiante0)
    {
        Console.WriteLine($"CI: {estudiante0.CI}\n" +
                    $"Nombre: {estudiante0.Name}\n" +
                    $"Sexo: {estudiante0.Gender}\n" +
                    $"Fecha Nacimiento: {estudiante0.BirthDay.ToShortDateString()}\n");
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
            $"Celular: {empleado.phoneNumber}\n" +
            $"Sueldo: {empleado.Salary}\n" +
            $"Impuesto: {empleado.pagaImpuesto()}\n");
    }
}