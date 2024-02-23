using Entities;
public class Demo
{
    static void Main()
    {
        #region "Variables"
        Biblioteca biblioteca = new Biblioteca();
        Libro libro0 = new Libro(0, "Principito", "Pepe", 12, 20);
        Libro libro1 = new Libro(1, "Troya", "Troy", 120, 5);
        Empleado empleado0 = new Empleado(115, "Pepe", "Peronio 5126", 376451252, 3000);
        Empleado empleado1 = new Empleado(120, "Pedro", "Peronio 2126", 376451352, 4000);
        Estudiante estudiante0 = new Estudiante(160, "Pato", "M", new DateTime(2022, 12, 12));
        Estudiante estudiante1 = new Estudiante(260, "Alex", "M", new DateTime(2021, 12, 12));
        #endregion
        #region "Agregar Datos"
        biblioteca.addEmpleado(empleado0);
        biblioteca.addEmpleado(empleado1);
        biblioteca.addLibro(libro0);
        biblioteca.addLibro(libro1);
        biblioteca.addEstudiante(estudiante0);
        biblioteca.addEstudiante(estudiante1);
        libro0.stock = biblioteca.giveBook(libro0);
        libro1.stock = biblioteca.returnStock(libro1);
        #endregion
        #region "Mostrar Datos"
        mostrarLibro(biblioteca);
        Console.ReadKey();
        Console.Clear();
        mostrarEstudiante(biblioteca);
        Console.ReadKey();
        Console.Clear();
        mostrarEmpleado(biblioteca);
        Console.ReadKey();
        Console.Clear();
        #endregion
    }

    private static void mostrarEstudiante(Biblioteca biblioteca)
    {
        Console.WriteLine("\nESTUDIANTES\n");
        foreach (Estudiante estudiante in biblioteca.getEstudiante())
        {
            Console.WriteLine($"CI: {estudiante.CI}\n" +
                    $"Nombre: {estudiante.Name}\n" +
                    $"Sexo: {estudiante.Gender}\n" +
                    $"Fecha Nacimiento: {estudiante.BirthDay.ToShortDateString()}\n");
        }
    }
    private static void mostrarLibro(Biblioteca biblioteca)
    {
        Console.WriteLine("\nLIBROS\n");
        foreach (Libro libro in biblioteca.getLibros())
        {
            Console.WriteLine($"ID: {libro.Id}\n" +
                    $"Nombre: {libro.Title}\n" +
                    $"Autor: {libro.Author}\n" +
                    $"Páginas: {libro.numPage}\n" +
                    $"Stock: {libro.stock}\n");
        }
    }
    private static void mostrarEmpleado(Biblioteca biblioteca)
    {
        Console.WriteLine("\nEMPLEADOS\n");
        foreach (Empleado empleado in biblioteca.getEmpleado())
        {
            Console.WriteLine($"CI: {empleado.Ci}\n" +
                $"Nombre: {empleado.Name}\n" +
                $"Dirección: {empleado.Address}\n" +
                $"Celular: {empleado.phoneNumber}\n" +
                $"Sueldo: {empleado.Salary}\n" +
                $"Impuesto: {empleado.pagaImpuesto()}\n");
        }
    }
}