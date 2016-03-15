using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using PromoFinder.Models.Mapping;

namespace PromoFinder.Models
{
    public partial class nortestr_promoContext : DbContext
    {
        static nortestr_promoContext()
        {
            Database.SetInitializer<nortestr_promoContext>(null);
        }

        public nortestr_promoContext()
            : base("Name=nortestr_promoContext")
        {
        }

        public DbSet<curtidas_lojas> curtidas_lojas { get; set; }
        public DbSet<curtidas_promocoes> curtidas_promocoes { get; set; }
        public DbSet<loja> lojas { get; set; }
        public DbSet<promoco> promocoes { get; set; }
        public DbSet<usuario> usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new curtidas_lojasMap());
            modelBuilder.Configurations.Add(new curtidas_promocoesMap());
            modelBuilder.Configurations.Add(new lojaMap());
            modelBuilder.Configurations.Add(new promocoMap());
            modelBuilder.Configurations.Add(new usuarioMap());
        }
    }
}
