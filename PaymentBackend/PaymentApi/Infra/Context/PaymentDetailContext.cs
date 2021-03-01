using Microsoft.EntityFrameworkCore;
using PaymentApi.Context.Mapping;
using PaymentApi.Domain;

namespace PaymentApi.Infra.Context
{
    public class PaymentDetailContext : DbContext
    {
        public PaymentDetailContext(DbContextOptions<PaymentDetailContext> options) : base(options)
        {

        }

        public DbSet<PaymentDetail> PaymentDetails{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PaymentDetailMap());
        }

    }
}
