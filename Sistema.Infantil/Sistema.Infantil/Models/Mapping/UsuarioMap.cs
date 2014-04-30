using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Sistema.Infantil.Models.Mapping
{
    public class UsuarioMap : EntityTypeConfiguration<Usuario>
    {
        public UsuarioMap()
        {
            // Primary Key
            this.HasKey(t => t.ID_USUARIO);

            // Properties
            this.Property(t => t.NM_USUARIO)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.NM_LOGIN)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.NM_SENHA)
                .IsRequired()
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("Usuarios");
            this.Property(t => t.ID_USUARIO).HasColumnName("ID_USUARIO");
            this.Property(t => t.ID_LICENSA).HasColumnName("ID_LICENSA");
            this.Property(t => t.NM_USUARIO).HasColumnName("NM_USUARIO");
            this.Property(t => t.NM_LOGIN).HasColumnName("NM_LOGIN");
            this.Property(t => t.NM_SENHA).HasColumnName("NM_SENHA");
            this.Property(t => t.INT_TIPO).HasColumnName("INT_TIPO");
        }
    }
}
