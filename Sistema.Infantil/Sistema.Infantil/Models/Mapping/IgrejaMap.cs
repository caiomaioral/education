using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Sistema.Infantil.Models.Mapping
{
    public class IgrejaMap : EntityTypeConfiguration<Igreja>
    {
        public IgrejaMap()
        {
            // Primary Key
            this.HasKey(t => t.ID_IGREJA);

            // Properties
            this.Property(t => t.NM_NOME)
                .HasMaxLength(50);

            this.Property(t => t.NR_CNPJ)
                .HasMaxLength(14);

            this.Property(t => t.NR_CEP)
                .HasMaxLength(9);

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

            this.Property(t => t.NM_NOME_CONTRATANTE)
                .HasMaxLength(50);

            this.Property(t => t.NR_CPF_CONTRATANTE)
                .HasMaxLength(11);

            this.Property(t => t.NM_EMAIL_CONTRATANTE)
                .HasMaxLength(128);

            // Table & Column Mappings
            this.ToTable("Igreja");
            this.Property(t => t.ID_IGREJA).HasColumnName("ID_IGREJA");
            this.Property(t => t.ID_GRUPOCONGREGACIONAL).HasColumnName("ID_GRUPOCONGREGACIONAL");
            this.Property(t => t.NM_NOME).HasColumnName("NM_NOME");
            this.Property(t => t.NR_CNPJ).HasColumnName("NR_CNPJ");
            this.Property(t => t.NR_CEP).HasColumnName("NR_CEP");
            this.Property(t => t.TP_LOGRADOURO).HasColumnName("TP_LOGRADOURO");
            this.Property(t => t.NM_ENDERECO).HasColumnName("NM_ENDERECO");
            this.Property(t => t.NR_NUMERO).HasColumnName("NR_NUMERO");
            this.Property(t => t.NM_COMPLEMENTO).HasColumnName("NM_COMPLEMENTO");
            this.Property(t => t.NM_BAIRRO).HasColumnName("NM_BAIRRO");
            this.Property(t => t.NM_CIDADE).HasColumnName("NM_CIDADE");
            this.Property(t => t.NM_UF).HasColumnName("NM_UF");
            this.Property(t => t.NR_MUNICIPIO).HasColumnName("NR_MUNICIPIO");
            this.Property(t => t.NR_FONE).HasColumnName("NR_FONE");
            this.Property(t => t.NM_EMAIL).HasColumnName("NM_EMAIL");
            this.Property(t => t.NM_NOME_CONTRATANTE).HasColumnName("NM_NOME_CONTRATANTE");
            this.Property(t => t.NR_CPF_CONTRATANTE).HasColumnName("NR_CPF_CONTRATANTE");
            this.Property(t => t.NM_EMAIL_CONTRATANTE).HasColumnName("NM_EMAIL_CONTRATANTE");

            // Relationships
            this.HasOptional(t => t.GrupoCongregacional)
                .WithMany(t => t.Igrejas)
                .HasForeignKey(d => d.ID_GRUPOCONGREGACIONAL);

        }
    }
}
