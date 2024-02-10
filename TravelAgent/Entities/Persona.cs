using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Persona
    {
        public int Dni { get; set; } 
        public string Nombre { get; set; }
        public Persona()
        {

        }
        public Persona(int dni, string nombre)
        {
            Dni = dni;
            Nombre = nombre;
        }
    }
}
