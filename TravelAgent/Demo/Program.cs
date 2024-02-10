using Entities;
public class Demo
{
    static void Main()
    {
        Persona persona = new Persona(44652614, "Nico");
        Paquete paquete = new Paquete("Coca", new DateTime(2022, 12, 12), new DateTime(2022, 12, 14));
        Ticket ticket = new Ticket();
        ticket = new Ticket(persona, 100);
        paquete.addTicket(ticket);
        Ticket ticket2 = new Ticket(persona, 200);
        paquete.addTicket(ticket2);
        Ticket ticket3 = new Ticket(persona, 300);
        paquete.addTicket(ticket3);
        mostrarTicket(paquete);
    }

    private static void mostrarTicket(Paquete paquete)
    {
        foreach (Ticket item in paquete.getTicketList())
            Console.WriteLine($"Nombre: {item.persona.Nombre}\n" +
                $"Monto: {item.Monto}");
    }
}