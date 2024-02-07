using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Equipo
    {
        public string Serie { get; set; }
        public DateTime FechaVenta
        {
            get
            {
                return DateTime.Now;
            }
        }
        public Marca NombreMarca;
        public Modelo NombreModelo;
        public Equipo()
        {
        }
        public Equipo(Marca nombreMarca, Modelo nombreModelo, string serie)
        {
            NombreMarca = nombreMarca;
            NombreModelo = nombreModelo;
            Serie = serie;
        }
    }
}
