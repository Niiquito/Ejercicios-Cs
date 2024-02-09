using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Habitacion : Servicio
    {
        public ushort Numero { get; set; }
        public DateTime Desde { get; set; }
        public DateTime Hasta { get; set; }
        public decimal PrecioNoche { get; set; }
        public decimal montoHabitacion;
        public Habitacion()
        {

        }
        public Habitacion(ushort numero, DateTime desde, DateTime hasta) : this()
        {
            Numero = numero;
            Desde = desde;
            Hasta = hasta;
            PrecioNoche = 100;
            montoHabitacion = GetMonto();
        }
        private int cantidadDias()
        {
            int dias = Hasta.Day - Desde.Day;
            return dias;
        }
        public decimal GetMonto()
        {
            decimal precioNoche = PrecioNoche * cantidadDias();
            return precioNoche;
        }
    }
}
