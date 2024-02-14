using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Empleado
    {
        public int Ci { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int phoneNumber { get; set; }
        public Empleado()
        {

        }
        public Empleado(int ci, string name, string address, int phone)
        {
            this.Ci = ci;
            this.Name = name;
            this.Address = address;
            this.phoneNumber = phone;
        }
    }
}
