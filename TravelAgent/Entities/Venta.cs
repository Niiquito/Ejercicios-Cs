using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Venta
    {
        public Cliente cliente;
        public Paquete paquete;
        public List<Paquete> paquetes;
        public DateTime Fecha { get; set; }
        public Venta()
        {
            paquetes = new List<Paquete>();
        }
        public Venta(Cliente cliente, DateTime fecha)
        {
            this.cliente = cliente;
            Fecha = fecha;
        }
        public void AddPaquete(Paquete paquete)
        {
            paquetes.Add(paquete);
        }
        public void RemovePaquete(Paquete paquete)
        {
            paquetes.Remove(paquete);
        }
        public List<Paquete> GetPaquete()
        {
            return paquetes;
        }
    }
}
