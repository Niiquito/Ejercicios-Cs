using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Reserva
    {
        private List<Pasajero> pasajeroList;
        private List<Servicio> servicioList;
        public DateTime Fecha { get; set; }
        public byte CantidadPasajeros { get; }
        public Reserva()
        {
            pasajeroList = new();
            servicioList = new();
        }

        public void AddPasajero(Pasajero pasajero)
        {
            pasajeroList.Add(pasajero);
        }
        public List<Pasajero> GetPasajeros()
        {
            return pasajeroList;
        }
        public void AddServicio(Servicio nuevoServicio)
        {
            servicioList.Add(nuevoServicio);
        }
        public List<Servicio> GetServicios()
        {
            return servicioList;
        }
    }
}
