using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SisBooking.Models
{
    public class Reserva
    {
        [Key]
        public int Id { get; set; }        

        [Column(TypeName = "nvarchar(100)")]
        public string UserEmail { get; set; }

        [ForeignKey("Sede")]
        public int IdSede { get; set; }
        public Sede Sede { get; set; }
    }
}
