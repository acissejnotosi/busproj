
using BusCore.Repository.Entities.Model;
using BusProj.Repository.Entities.Model;
using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;
using MySql.Data.EntityFrameworkCore.Extensions;

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
        public DbSet<TipoOnibus> TipoOnibus { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("Server=localhost;Database=buscore;Uid=root;Pwd=teste123;port=3306");
        }
    }
}
