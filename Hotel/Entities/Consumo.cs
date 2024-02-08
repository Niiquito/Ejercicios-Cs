using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public  class Consumo : Servicio
    {
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public decimal Monto { get; set; }
        public Consumo()
        {
            Fecha = DateTime.Now;
        }
        public Consumo(string descripcion, decimal monto) : this()
        {
            this.Monto = monto;
            this.Descripcion = descripcion;
        }
        public decimal GetMonto()
        {
            return Monto;
        }
    }
}
