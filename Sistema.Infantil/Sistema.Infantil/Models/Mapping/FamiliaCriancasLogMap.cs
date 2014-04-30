using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Sistema.Infantil.Models.Mapping
{
    public class FamiliaCriancasLogMap : EntityTypeConfiguration<FamiliaCriancasLog>
    {
        public FamiliaCriancasLogMap()
        {
            // Primary Key
            this.HasKey(t => t.ID_FAMILIACRIANCASLOG);

            // Properties
            // Table & Column Mappings
            this.ToTable("FamiliaCriancasLog");
            this.Property(t => t.ID_FAMILIACRIANCASLOG).HasColumnName("ID_FAMILIACRIANCASLOG");
            this.Property(t => t.ID_FAMILIACRIANCAS).HasColumnName("ID_FAMILIACRIANCAS");
            this.Property(t => t.DT_ENTRADA).HasColumnName("DT_ENTRADA");
            this.Property(t => t.DT_SAIDA).HasColumnName("DT_SAIDA");

            // Relationships
            this.HasOptional(t => t.FamiliaCrianca)
                .WithMany(t => t.FamiliaCriancasLogs)
                .HasForeignKey(d => d.ID_FAMILIACRIANCAS);

        }
    }
}
