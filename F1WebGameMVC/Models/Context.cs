using F1WebGameMVC.Models.PODO;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace F1WebGame.Class
{
    public class Context : DbContext
    {
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Circuit> Circuit { get; set; }
        public virtual DbSet<Classements> Classement { get; set; }
        public virtual DbSet<Ecurie> Ecuries { get; set; }
        public virtual DbSet<Pays> Pays { get; set; }
        public virtual DbSet<Pilote> Pilote { get; set; }
        public virtual DbSet<Pneus> Pneus { get; set; }
        public virtual DbSet<Saison> Saison { get; set; }
        public virtual DbSet<Tour> Tour { get; set; }
        public virtual DbSet<Voiture> Voiture{ get; set; }


        public Context()
        {
        }

        public Context(DbContextOptions<Context> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=F1WebGame;TrustServerCertificate=True;Encrypt=False;persist security info=True;Trusted_Connection=True;");
            optionsBuilder.UseLazyLoadingProxies(true);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }


    }
}
