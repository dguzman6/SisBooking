using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SisBooking.Models
{
    public class Alojamiento
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "int")]
        public int Capacidad { get; set; }

        [Column(TypeName = "bit")]
        public bool Baño { get; set; }
        [Column(TypeName = "bit")]
        public bool CamaDoble { get; set; }
        [Column(TypeName = "bit")]
        public bool Camarote { get; set; }
        [Column(TypeName = "bit")]
        public bool Nevera { get; set; }
        [Column(TypeName = "bit")]
        public bool TV { get; set; }
        [Column(TypeName = "bit")]
        public bool Terraza { get; set; }
        [Column(TypeName = "nvarchar(max)")]
        public string Descripcion { get; set; }
        [Column(TypeName = "int")]
        public int TarifaOrd { get; set; }
        [Column(TypeName = "int")]
        public int TarifaEsp { get; set; }



        //Sedes Relation
        [ForeignKey("Sede")]
        public int IdSede { get; set; }
        public Sede Sede { get; set; }



    }
}
