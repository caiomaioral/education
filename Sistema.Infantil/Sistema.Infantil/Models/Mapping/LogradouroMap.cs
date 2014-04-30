using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Sistema.Infantil.Models.Mapping
{
    public class LogradouroMap : EntityTypeConfiguration<Logradouro>
    {
        public LogradouroMap()
        {
            // Primary Key
            this.HasKey(t => t.ID_LOGRADOURO);

            // Properties
            this.Property(t => t.NM_LOGRADOURO)
                .HasMaxLength(150);

            // Table & Column Mappings
            this.ToTable("Logradouro");
            this.Property(t => t.ID_LOGRADOURO).HasColumnName("ID_LOGRADOURO");
            this.Property(t => t.NM_LOGRADOURO).HasColumnName("NM_LOGRADOURO");
        }
    }
}
