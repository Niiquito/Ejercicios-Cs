using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Servicio
    {
        Habitacion habitacion;
        Consumo consumo;
        public decimal GetMonto()
        {
            decimal monto = habitacion.GetMonto() + consumo.GetMonto();
            return monto;
        }
        
    }

}
