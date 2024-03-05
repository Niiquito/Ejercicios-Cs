using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Autores
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int autorID { get; set; }
        public string autorNombre { get; set; }
        public string autorApellido { get; set; }
        public string telefono { get; set; }
        public string direccion { get; set; }
        public string ciudad { get; set; }
        public string estado { get; set; }
        public string codigoPostal { get; set; }
        public byte contratado { get; set; }
    }
}
