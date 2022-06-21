using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SisBooking.Models
{
    public class FechaEspecial
    {
        [Key]
        public int IdFecha { get; set; }

        [Column(TypeName = "date")]
        public DateTime Fecha { get; set; }
    }
}
