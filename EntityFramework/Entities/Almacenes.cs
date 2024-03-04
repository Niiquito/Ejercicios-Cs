using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class Almacenes
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int almacenID { get; set; }
        public string almacenNombre { get; set; }
        public string almacenDireccion { get; set; }
        public string ciudad { get; set; }
        public string estado { get; set; }
        public string codigoPostal { get; set; }
    }
}
