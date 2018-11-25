
using BusCore.Repository.Entities.Model;
using BusProj.Repository.Entities.Model;
using Microsoft.EntityFrameworkCore;

namespace BusProj.Repository.Entities
{
    public class BusCoreContext : DbContext
    {
        public BusCoreContext() : base()
        {

        }

        public DbSet<Deteccao> Deteccao { get; set; }
        public DbSet<Embreagem> Embreagem { get; set; }
        public DbSet<Freio> Freio { get; set; }
        public DbSet<Linha> Linha { get; set; }
        public DbSet<Ocorrencia> Ocorrencia { get; set; }
        public DbSet<Severidade> Severidade { get; set; }
        public DbSet<Suspensao> Suspensao { get; set; }
        public DbSet<TipoDescricao> TipoDescricao { get; set; }
        public DbSet<RelatorioBuracos> RelatorioBuraco { get; set; }
        public DbSet<RelatorioLombadas> RelatorioLombada { get; set; }
        public DbSet<RelatorioParadas> RelatorioParada { get; set; }
        public DbSet<RelatorioSemaforos> RelatorioSemaforo { get; set; }
        public DbSet<TipoOnibus> TipoOnibus { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=CIBIEN-PC\\CIBIEN;Initial Catalog=BusCore;Persist Security Info=True;User ID=sa;Password=teste");
        }
    }
}
