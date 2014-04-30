using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Sistema.Infantil.Models.Mapping
{
    public class FamiliaMap : EntityTypeConfiguration<Familia>
    {
        public FamiliaMap()
        {
            // Primary Key
            this.HasKey(t => t.ID_FAMILIA);

            // Properties
            this.Property(t => t.NM_FAMILIA)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Familia");
            this.Property(t => t.ID_FAMILIA).HasColumnName("ID_FAMILIA");
            this.Property(t => t.NM_FAMILIA).HasColumnName("NM_FAMILIA");
        }
    }
}
