using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Cliente : Persona
    {
        public string cuit_cuil { get; set; }
        public Cliente(int dni, string nombre, string cuit_cuil) : base(dni, nombre)
        {
            this.cuit_cuil = cuit_cuil;
        }
    }
}
