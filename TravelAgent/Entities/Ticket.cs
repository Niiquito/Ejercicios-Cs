using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Ticket
    {
        public Persona persona;
        public decimal Monto { get; set; }

        public Ticket(Persona persona, decimal monto)
        {
            this.persona = persona;
            Monto = monto;
        }
    }
}
