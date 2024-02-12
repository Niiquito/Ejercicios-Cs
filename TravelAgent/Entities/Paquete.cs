namespace Entities
{
    public class Paquete
    {
        public string Descripcion { get; set; }
        public DateTime FechaInicial { get; set; }
        public DateTime FechaFinal { get; set; }
        public ushort NumeroDias
        {
            get
            {
                ushort numeroDias = Convert.ToUInt16(FechaFinal - FechaInicial);
                return numeroDias;
            }
        }
        public int NumeroTickets
        {
            get
            {
                int ticketCount = TicketList.Count;
                return ticketCount;
            }
        }
        List<Ticket> TicketList { get; set; }
        public Paquete()
        {
            TicketList = new List<Ticket>();
        }
        public Paquete(string descripcion, DateTime fechaInicial, DateTime fechaFinal) : this()
        {
            Descripcion = descripcion;
            FechaInicial = fechaInicial;
            FechaFinal = fechaFinal;
        }
        public void addTicket(Ticket ticket)
        {
            TicketList.Add(ticket);
        }
        public List<Ticket> getTicketList()
        {
            return TicketList;
        }
        public void RemoveTicket(Ticket ticket)
        {
            TicketList.Remove(ticket);
        }
        public decimal montoPaquetes()
        {
            decimal montoPaquetes = 0;
            foreach (Ticket ticket in TicketList)
                montoPaquetes = ticket.Monto + montoPaquetes;
            return montoPaquetes;
        }

    }
}