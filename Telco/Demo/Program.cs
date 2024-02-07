using Entities;
public class Demo
{
    static void Main()
    {
        //ushort codigoArea;
        //uint numero;
        //Console.Write("Ingrese codigo area: ");
        //codigoArea = ushort.Parse(Console.ReadLine());
        //Console.Write("Ingrese numero: ");
        //numero = uint.Parse(Console.ReadLine());
        //Linea linea = new Linea(codigoArea, numero);
        //Console.WriteLine($"Estado de Cuenta: (Activa/Inactiva)");
        //string opcion = Console.ReadLine();
        //switch (opcion)
        //{
        //    case "A":
        //        linea.Reactivar();
        //        break;
        //    case "I":
        //        linea.Suspender();
        //        break;
        //    default:
        //        Console.WriteLine("Error");
        //        break;
        //}
        //informeLinea(linea);
        Equipo nuevoEquipo = new Equipo();
        Marca nuevaMarca = new Marca("Toyota");
        Modelo nuevoModelo = new Modelo("Supra");
        nuevoEquipo = new Equipo(nuevaMarca, nuevoModelo, "Mk10");
        Console.WriteLine($"\nMarca: {nuevoEquipo.NombreMarca}\n" +
            $"Modelo: {nuevoEquipo.NombreModelo}\n" +
            $"Serie: {nuevoEquipo.Serie}\n" +
            $"Fecha venta: {nuevoEquipo.FechaVenta}");
    }

    private static void informeLinea(Linea linea)
    {
        Console.Write($"Codigo: {linea.codigoArea}\n" +
                    $"Numero: {linea.numero}\n" +
                    $"Estado: {linea.Estado}\n");
    }
}