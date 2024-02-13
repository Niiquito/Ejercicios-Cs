using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Concesionaria
    {
        public List<Coche> coches;
        public Concesionaria()
        {
            coches = new List<Coche>();
        }
        public void addCoche(Coche coche)
        {
            coches.Add(coche);
        }
        public void removeCoche(Coche coche)
        {
            coches.Remove(coche);
        }
        public void removeAll()
        {
            coches.Clear();
        }
        public List<Coche> getCoche()
        {
            return coches;
        }
    }
}
