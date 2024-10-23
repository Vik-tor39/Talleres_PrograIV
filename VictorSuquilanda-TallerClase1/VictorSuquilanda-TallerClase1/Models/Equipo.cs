using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VictorSuquilanda_TallerClase1.Models
{
    public class Equipo
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        public string Ciudad { get; set; }
        [Range(0, 100)]
        public int Titulos { get; set; }
        public Boolean AceptaExtranjeros {  get; set; }
        public Estadio? Estadio { get; set; }
        [ForeignKey("Estadio")]
        public int IdEstadio { get; set; }
    }
}
