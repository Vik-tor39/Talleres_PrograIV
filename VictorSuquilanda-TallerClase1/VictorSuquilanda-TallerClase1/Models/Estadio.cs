using System.ComponentModel.DataAnnotations;

namespace VictorSuquilanda_TallerClase1.Models
{
    public class Estadio
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        public string Direccion { get; set; }
        [Range(1000,10000)]
        public int Capacidad { get; set; }
    }
}
