using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PromoFinder.Models.Mapping
{
    public class curtidas_promocoesMap : EntityTypeConfiguration<curtidas_promocoes>
    {
        public curtidas_promocoesMap()
        {
            // Primary Key
            this.HasKey(t => t.curpro_id);

            // Properties
            // Table & Column Mappings
            this.ToTable("curtidas_promocoes", "nortestr_promo");
            this.Property(t => t.curpro_id).HasColumnName("curpro_id");
            this.Property(t => t.promocao_id).HasColumnName("promocao_id");
            this.Property(t => t.usuario_id).HasColumnName("usuario_id");
            this.Property(t => t.status).HasColumnName("status");
        }
    }
}
