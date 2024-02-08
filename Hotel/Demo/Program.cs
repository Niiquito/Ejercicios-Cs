using Entities;
public class Demo
{
    static void Main()
    {
        Reserva reserva = new Reserva();
        Pasajero pasajero0 = new Pasajero();
        Pasajero pasajero1 = new Pasajero();
        pasajero0.Nombre = "Paty";
        pasajero0.FechaNacimiento = new DateTime(2013, 12, 12);
        pasajero0.Dni = "44652614";
        Habitacion habitacion0 = new Habitacion(12, new DateTime(2024, 12, 12), new DateTime(2024, 12, 14));
        Consumo consumo0 = new Consumo("Asasasa", 100);
        reserva.AddServicio(habitacion0);
        reserva.AddServicio(consumo0);
        reserva.AddPasajero(pasajero0);
        pasajero1.Nombre = "Pita";
        pasajero1.Dni = "46541252";
        pasajero1.FechaNacimiento = new DateTime(2002, 12, 12);
        reserva.AddPasajero(pasajero1);
        foreach (Pasajero item in reserva.GetPasajeros())
        {
            Console.WriteLine($"Nombre: {item.Nombre}\n" +
                $"DNI: {item.Dni}\n");
        }
        foreach (Servicio servicio in reserva.GetServicios())
        {
            switch (servicio)
            {
                case Habitacion habitacion:
                    Console.Write($"Numero: {habitacion.Numero}\n" +
                        $"Hasta: {habitacion.Hasta}\n");
                    break;
                case Consumo consumo:
                    Console.Write($"Fecha: {consumo.Fecha}\n" +
                        $"Consumo: {consumo.GetMonto()}\n");
                    break;
            }
            //Console.WriteLine($"Monto: {servicio.GetMonto()}");
        }
    }
}