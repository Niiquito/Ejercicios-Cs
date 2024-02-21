using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Videojuego
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public string Genero { get; set; }
        public string Plataforma { get; set; }

        public Videojuego()
        {

        }
        public Videojuego(string nombre, decimal precio, string genero, string plataforma) : this()
        {
            Nombre = nombre;
            Precio = precio;
            Genero = genero;
            Plataforma = plataforma;
        }
    }
}
