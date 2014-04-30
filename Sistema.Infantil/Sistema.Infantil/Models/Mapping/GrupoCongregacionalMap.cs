using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Sistema.Infantil.Models.Mapping
{
    public class GrupoCongregacionalMap : EntityTypeConfiguration<GrupoCongregacional>
    {
        public GrupoCongregacionalMap()
        {
            // Primary Key
            this.HasKey(t => t.ID_GRUPOCONGREGACIONAL);

            // Properties
            this.Property(t => t.NM_NOME)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("GrupoCongregacional");
            this.Property(t => t.ID_GRUPOCONGREGACIONAL).HasColumnName("ID_GRUPOCONGREGACIONAL");
            this.Property(t => t.NM_NOME).HasColumnName("NM_NOME");
        }
    }
}
