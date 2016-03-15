using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PromoFinder.Models.Mapping
{
    public class promocoMap : EntityTypeConfiguration<promoco>
    {
        public promocoMap()
        {
            // Primary Key
            this.HasKey(t => t.promocao_id);

            // Properties
            this.Property(t => t.descricao)
                .IsRequired()
                .HasMaxLength(1073741823);

            // Table & Column Mappings
            this.ToTable("promocoes", "nortestr_promo");
            this.Property(t => t.promocao_id).HasColumnName("promocao_id");
            this.Property(t => t.loja_id).HasColumnName("loja_id");
            this.Property(t => t.descricao).HasColumnName("descricao");
            this.Property(t => t.datacadastro).HasColumnName("datacadastro");
            this.Property(t => t.datavalidade).HasColumnName("datavalidade");
            this.Property(t => t.status).HasColumnName("status");
            this.Property(t => t.visualizacoes).HasColumnName("visualizacoes");
        }
    }
}
