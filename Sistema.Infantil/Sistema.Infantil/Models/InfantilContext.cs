using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Sistema.Infantil.Models.Mapping;

namespace Sistema.Infantil.Models
{
    public partial class InfantilContext : DbContext
    {
        static InfantilContext()
        {
            Database.SetInitializer<InfantilContext>(null);
        }

        public InfantilContext()
            : base("Name=InfantilContext")
        {
        }

        public DbSet<Familia> Familias { get; set; }
        public DbSet<FamiliaCrianca> FamiliaCriancas { get; set; }
        public DbSet<FamiliaCriancasLog> FamiliaCriancasLogs { get; set; }
        public DbSet<FamiliaMembro> FamiliaMembros { get; set; }
        public DbSet<GrupoCongregacional> GrupoCongregacionals { get; set; }
        public DbSet<Igreja> Igrejas { get; set; }
        public DbSet<Logradouro> Logradouroes { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new FamiliaMap());
            modelBuilder.Configurations.Add(new FamiliaCriancaMap());
            modelBuilder.Configurations.Add(new FamiliaCriancasLogMap());
            modelBuilder.Configurations.Add(new FamiliaMembroMap());
            modelBuilder.Configurations.Add(new GrupoCongregacionalMap());
            modelBuilder.Configurations.Add(new IgrejaMap());
            modelBuilder.Configurations.Add(new LogradouroMap());
            modelBuilder.Configurations.Add(new sysdiagramMap());
            modelBuilder.Configurations.Add(new UsuarioMap());
        }
    }
}
