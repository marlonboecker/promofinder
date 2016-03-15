using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PromoFinder.Models.Mapping
{
    public class lojaMap : EntityTypeConfiguration<loja>
    {
        public lojaMap()
        {
            // Primary Key
            this.HasKey(t => t.loja_id);

            // Properties
            this.Property(t => t.nome)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.logo)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.avaliacao)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.rua)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.numero)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.complemento)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.cidade)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.estado)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.telefone)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.email)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("lojas", "nortestr_promo");
            this.Property(t => t.loja_id).HasColumnName("loja_id");
            this.Property(t => t.nome).HasColumnName("nome");
            this.Property(t => t.logo).HasColumnName("logo");
            this.Property(t => t.avaliacao).HasColumnName("avaliacao");
            this.Property(t => t.rua).HasColumnName("rua");
            this.Property(t => t.numero).HasColumnName("numero");
            this.Property(t => t.complemento).HasColumnName("complemento");
            this.Property(t => t.cidade).HasColumnName("cidade");
            this.Property(t => t.estado).HasColumnName("estado");
            this.Property(t => t.telefone).HasColumnName("telefone");
            this.Property(t => t.email).HasColumnName("email");
            this.Property(t => t.datacadastro).HasColumnName("datacadastro");
        }
    }
}
