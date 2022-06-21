using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SisBooking.Models
{
    public class Sede
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(256)")]
        public string Nombre { get; set; }

        [Column(TypeName = "nvarchar(max)")]
        public string? Descripcion { get; set; }

        [Column(TypeName = "nvarchar(max)")]
        public string Tipo { get; set; }

        [Column(TypeName = "nvarchar(max)")]
        public string Ubicacion { get; set; }

        public List<Alojamiento> Alojamientos { get; set; }
    }
}
