using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PromoFinder.Models.Mapping
{
    public class usuarioMap : EntityTypeConfiguration<usuario>
    {
        public usuarioMap()
        {
            // Primary Key
            this.HasKey(t => t.usuario_id);

            // Properties
            this.Property(t => t.nome)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.email)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.cep)
                .IsRequired()
                .HasMaxLength(10);

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

            this.Property(t => t.senha)
                .IsRequired()
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("usuarios", "nortestr_promo");
            this.Property(t => t.usuario_id).HasColumnName("usuario_id");
            this.Property(t => t.nome).HasColumnName("nome");
            this.Property(t => t.email).HasColumnName("email");
            this.Property(t => t.cep).HasColumnName("cep");
            this.Property(t => t.rua).HasColumnName("rua");
            this.Property(t => t.numero).HasColumnName("numero");
            this.Property(t => t.complemento).HasColumnName("complemento");
            this.Property(t => t.cidade).HasColumnName("cidade");
            this.Property(t => t.estado).HasColumnName("estado");
            this.Property(t => t.datanascimento).HasColumnName("datanascimento");
            this.Property(t => t.datacadastro).HasColumnName("datacadastro");
            this.Property(t => t.senha).HasColumnName("senha");
            this.Property(t => t.status).HasColumnName("status");
        }
    }
}
