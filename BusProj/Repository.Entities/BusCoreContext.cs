
using BusCore.Business.Identity;
using BusCore.Repository.Entities.Model;
using BusProj.Repository.Entities.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
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
        //public DbSet<User> User { get; set; }
        //public DbSet<Organization> Organization { get; set; }
        public DbSet<HistoricoLinha> HistoricoLinha { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("Server=localhost;Database=buscore;Uid=root;Pwd=teste123;port=3306");
        }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //builder.Entity<User>(user => user.HasIndex(x => x.Locale).IsUnique(false));

            //builder.Entity<Organization>(org =>
            //{
            //    org.ToTable("Organizations");
            //    org.HasKey(x => x.Id);

            //    org.HasMany<User>().WithOne().HasForeignKey(x => x.OrgId).IsRequired(false);
            //});
        }
    }
}
