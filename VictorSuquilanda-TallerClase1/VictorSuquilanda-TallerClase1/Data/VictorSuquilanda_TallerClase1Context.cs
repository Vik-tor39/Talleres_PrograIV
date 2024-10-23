using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VictorSuquilanda_TallerClase1.Models;

namespace VictorSuquilanda_TallerClase1.Data
{
    public class VictorSuquilanda_TallerClase1Context : DbContext
    {
        public VictorSuquilanda_TallerClase1Context (DbContextOptions<VictorSuquilanda_TallerClase1Context> options)
            : base(options)
        {
        }

        public DbSet<VictorSuquilanda_TallerClase1.Models.Equipo> Equipo { get; set; } = default!;
        public DbSet<VictorSuquilanda_TallerClase1.Models.Jugador> Jugador { get; set; } = default!;
        public DbSet<VictorSuquilanda_TallerClase1.Models.Estadio> Estadio { get; set; } = default!;
    }
}
