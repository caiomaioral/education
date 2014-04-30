using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Sistema.Infantil.Models.Mapping
{
    public class FamiliaMembroMap : EntityTypeConfiguration<FamiliaMembro>
    {
        public FamiliaMembroMap()
        {
            // Primary Key
            this.HasKey(t => t.ID_FAMILIAMEMBROS);

            // Properties
            this.Property(t => t.NM_NOME)
                .HasMaxLength(50);

            this.Property(t => t.NR_DOCUMENTO)
                .HasMaxLength(20);

            this.Property(t => t.NR_CEP)
                .HasMaxLength(8);

            this.Property(t => t.NM_ENDERECO)
                .HasMaxLength(50);

            this.Property(t => t.NR_NUMERO)
                .HasMaxLength(20);

            this.Property(t => t.NM_COMPLEMENTO)
                .HasMaxLength(50);

            this.Property(t => t.NM_BAIRRO)
                .HasMaxLength(50);

            this.Property(t => t.NM_CIDADE)
                .HasMaxLength(50);

            this.Property(t => t.NM_UF)
                .HasMaxLength(2);

            this.Property(t => t.NR_FONE)
                .HasMaxLength(15);

            this.Property(t => t.NM_EMAIL)
                .HasMaxLength(128);

            // Table & Column Mappings
            this.ToTable("FamiliaMembros");
            this.Property(t => t.ID_FAMILIAMEMBROS).HasColumnName("ID_FAMILIAMEMBROS");
            this.Property(t => t.ID_FAMILIA).HasColumnName("ID_FAMILIA");
            this.Property(t => t.ID_IGREJA).HasColumnName("ID_IGREJA");
            this.Property(t => t.TP_RESPONSAVEL).HasColumnName("TP_RESPONSAVEL");
            this.Property(t => t.NM_NOME).HasColumnName("NM_NOME");
            this.Property(t => t.DT_NASCIMENTO).HasColumnName("DT_NASCIMENTO");
            this.Property(t => t.TP_DOCUMENTO).HasColumnName("TP_DOCUMENTO");
            this.Property(t => t.NR_DOCUMENTO).HasColumnName("NR_DOCUMENTO");
            this.Property(t => t.NR_CEP).HasColumnName("NR_CEP");
            this.Property(t => t.NM_ENDERECO).HasColumnName("NM_ENDERECO");
            this.Property(t => t.NR_NUMERO).HasColumnName("NR_NUMERO");
            this.Property(t => t.NM_COMPLEMENTO).HasColumnName("NM_COMPLEMENTO");
            this.Property(t => t.NM_BAIRRO).HasColumnName("NM_BAIRRO");
            this.Property(t => t.NM_CIDADE).HasColumnName("NM_CIDADE");
            this.Property(t => t.NM_UF).HasColumnName("NM_UF");
            this.Property(t => t.NR_MUNICIPIO).HasColumnName("NR_MUNICIPIO");
            this.Property(t => t.NR_FONE).HasColumnName("NR_FONE");
            this.Property(t => t.NM_EMAIL).HasColumnName("NM_EMAIL");
            this.Property(t => t.DS_FOTO).HasColumnName("DS_FOTO");

            // Relationships
            this.HasOptional(t => t.Familia)
                .WithMany(t => t.FamiliaMembros)
                .HasForeignKey(d => d.ID_FAMILIA);

        }
    }
}
