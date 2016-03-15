using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PromoFinder.Models.Mapping
{
    public class curtidas_lojasMap : EntityTypeConfiguration<curtidas_lojas>
    {
        public curtidas_lojasMap()
        {
            // Primary Key
            this.HasKey(t => t.curloj_id);

            // Properties
            // Table & Column Mappings
            this.ToTable("curtidas_lojas", "nortestr_promo");
            this.Property(t => t.curloj_id).HasColumnName("curloj_id");
            this.Property(t => t.loja_id).HasColumnName("loja_id");
            this.Property(t => t.usuario_id).HasColumnName("usuario_id");
            this.Property(t => t.status).HasColumnName("status");
        }
    }
}
