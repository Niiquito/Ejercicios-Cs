using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Entities
{
    public class titulos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int tituloId { get; set; }
        public string tituloName { get; set; }
        public string Genero { get; set; }
        public int editorialID { get; set; }
        [ForeignKey("editorialID")]
        public virtual Editorial editorial { get; set; }
        public decimal precio { get; set; }
        public decimal adelanto { get; set; }
        public int regalias { get; set; }
        public int ventaAnual { get; set; }
        public string notas { get; set; }
        public DateTime fechaPublicacion { get; set; }
    }
}
