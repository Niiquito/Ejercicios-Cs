using Entities;
public class Demo
{
    static void Main()
    {
        Reserva reserva = new Reserva();
        Servicio servicio0 = new Servicio();
        List<Reserva> reservas = new List<Reserva>();
        Pasajero pasajero0 = new Pasajero();
        pasajero0.Nombre = "Paty";
        pasajero0.FechaNacimiento = new DateTime(2013, 12, 12);
        pasajero0.Dni = "44652614";
        Habitacion habitacion0 = new Habitacion(12, new DateTime(2024, 12, 12), new DateTime(2024, 12, 14));
        reserva.AddServicio(habitacion0);
        for (int i = 0; i < 3; i++)
        {
            Consumo consumo0 = new Consumo("asdasd", decimal.Parse(Console.ReadLine()));
            //Consumo consumo1 = new Consumo("Papas fritas", 50);
            servicio0 = new Servicio(habitacion0, consumo0);
            reserva.AddServicio(consumo0);
            //reserva.AddServicio(consumo1);
        }
        reserva.AddPasajero(pasajero0);
        reservas.Add(reserva);
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
        }
        Console.WriteLine($"Monto total: {servicio0.GetMonto()}");
    }
}