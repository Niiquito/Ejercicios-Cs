using Entities;
public class Demo
{
    static void Main()
    {
        Venta venta = new Venta();
        Persona persona = new Persona(44652614, "Nico");
        Persona persona2 = new Persona(44652614, "Alex");
        Cliente cliente0 = new Cliente(44652615, "Pepe", "20-44652615-7");
        venta = new Venta(cliente0, new DateTime(2022, 12, 12));
        Paquete paquete = new Paquete("Coca", new DateTime(2022, 12, 12), new DateTime(2022, 12, 14));
        venta.AddPaquete(paquete);
        Ticket ticket = new Ticket(persona, 100);
        Ticket ticket2 = new Ticket(persona, 200);
        paquete.addTicket(ticket);
        paquete.addTicket(ticket2);
        Paquete paquete2 = new Paquete("Pepsi", new DateTime(2022, 12, 12), new DateTime(2022, 12, 14));
        venta.AddPaquete(paquete2);
        Ticket ticket3 = new Ticket(persona2, 500);
        Ticket ticket4 = new Ticket(persona2, 100);
        paquete2.addTicket(ticket3);
        paquete2.addTicket(ticket4);
        mostrarVenta(venta);
        mostrarTicket(paquete);
        conteoMontoTickets(paquete);
        mostrarTicket(paquete2);
        conteoMontoTickets(paquete2);
        Console.WriteLine($"\nMonto total paquetes: {venta.montoTotal()}");
    }

    private static void conteoMontoTickets(Paquete paquete2)
    {
        Console.WriteLine($"\nConteo tickets: {paquete2.NumeroTickets}");
        Console.WriteLine($"Monto total: {paquete2.montoPaquetes()}");
    }

    private static void mostrarVenta(Venta venta)
    {
        Console.WriteLine("\nVENTAS");
        foreach (Paquete item in venta.GetPaquete())
            Console.WriteLine($"Descripción: {item.Descripcion}\n" +
                $"Fecha Inicial: {item.FechaFinal}\n" +
                $"Fecha Final: {item.FechaFinal}\n" +
                $"Cliente: {venta.cliente.Nombre}");
    }

    private static void mostrarTicket(Paquete paquete)
    {
        Console.WriteLine("\nTICKETS");
        foreach (Ticket item in paquete.getTicketList())
            Console.WriteLine($"Nombre: {item.persona.Nombre}\n" +
                $"Monto: {item.Monto}");
    }
}