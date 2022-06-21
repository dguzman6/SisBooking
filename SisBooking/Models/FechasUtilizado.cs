using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SisBooking.Models
{
    public class FechasUtilizado
    {

        [Key]
        public int Id { get; set; }
        [Column(TypeName = "date")]
        public DateTime Fecha { get; set; }
        [Column(TypeName = "int")]
        public int IdAlojamiento { get; set; }
    }
}
