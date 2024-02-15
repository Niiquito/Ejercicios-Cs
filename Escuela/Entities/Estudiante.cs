using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Estudiante
    {
        public int CI { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public DateTime BirthDay { get; set; }
        public Estudiante()
        {

        }
        public Estudiante(int ci, string name, string gender, DateTime birthday)
        {
            this.CI = ci;
            this.Name = name;
            this.Gender = gender;
            this.BirthDay = birthday;
        }
    }
}
