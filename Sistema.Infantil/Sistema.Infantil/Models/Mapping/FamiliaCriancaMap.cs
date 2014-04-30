using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Sistema.Infantil.Models.Mapping
{
    public class FamiliaCriancaMap : EntityTypeConfiguration<FamiliaCrianca>
    {
        public FamiliaCriancaMap()
        {
            // Primary Key
            this.HasKey(t => t.ID_FAMILIACRIANCAS);

            // Properties
            this.Property(t => t.NM_NOME)
                .HasMaxLength(50);

            this.Property(t => t.DS_OBSERVACAO)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("FamiliaCriancas");
            this.Property(t => t.ID_FAMILIACRIANCAS).HasColumnName("ID_FAMILIACRIANCAS");
            this.Property(t => t.ID_FAMILIA).HasColumnName("ID_FAMILIA");
            this.Property(t => t.ID_IGREJA).HasColumnName("ID_IGREJA");
            this.Property(t => t.NM_NOME).HasColumnName("NM_NOME");
            this.Property(t => t.DT_NASCIMENTO).HasColumnName("DT_NASCIMENTO");
            this.Property(t => t.DS_FOTO).HasColumnName("DS_FOTO");
            this.Property(t => t.DS_OBSERVACAO).HasColumnName("DS_OBSERVACAO");

            // Relationships
            this.HasOptional(t => t.Familia)
                .WithMany(t => t.FamiliaCriancas)
                .HasForeignKey(d => d.ID_FAMILIA);

        }
    }
}
