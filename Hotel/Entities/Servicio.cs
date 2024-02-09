using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Servicio
    {
        public Habitacion habitacion { get; set; }
        public Consumo consumo { get; set; }
        public Servicio()
        {

        }
        decimal montoTotal;
        public Servicio(Habitacion monto, Consumo montoConsumo) : this()
        {
            montoTotal += monto.montoHabitacion + montoConsumo.Monto;
        }
        public decimal GetMonto()
        {
            return montoTotal;
        }
    }

}
