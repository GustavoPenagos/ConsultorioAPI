using ConsultorioAPI.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using OdontologiaWeb.Models;

namespace ConsultorioAPI.Data
{
    public class consultorioDBContext : DbContext
    {
        public consultorioDBContext(DbContextOptions<consultorioDBContext>options):base (options) { }

        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Anamnesis> Anamnesis { get; set;}
        public DbSet<Ant_Familiar> Ant_Familiar { get; set; }
        public DbSet<TipoDocumento> TipoDocumento { get; set;}
        public DbSet<Ciudad> Ciudad { get; set; }
        public DbSet<Departamento> Departamento { get; set;}
        public DbSet<Estomatologico> Estomatologico { get; set;}
        public DbSet<Genero> Genero { get; set; }
        public DbSet<Convecciones> Convecciones { get; set; }
        public DbSet<EstadoCivil> EstadoCivil { get; set; }
        public DbSet<PlanTratamiento> PlanTratamiento { get;set; }
        public DbSet<EstadoTratamiento> EstadoTratamiento { get; set; }
        public DbSet<CartaDentalAdulto> cartaDentalAdulto { get; set; }
        public DbSet<CartaDentalNino> cartaDentalNino{ get; set; }
        public DbSet<Citas> Citas { get; set; }
        public DbSet<Imagenes> Imagenes { get; set; }
        public DbSet<Contabilidad> Contabilidad { get; set; }
        public DbSet<Urgencia> Urgencias { get; set; }

    }
}
