using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Cargos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int cargoID { get; set; }
        public string cargoDescripcion { get; set; }
        public Int16 nivelMinimo { get; set; }
        public Int16 nivelMaximo { get; set; }
    }
}
