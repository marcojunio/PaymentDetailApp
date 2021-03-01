using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PaymentApi.Context.Config;
using PaymentApi.Domain;

namespace PaymentApi.Context.Mapping
{
    public class PaymentDetailMap : PaymentEntityTypeConfiguration<PaymentDetail>
    {
        public void Configure(EntityTypeBuilder<PaymentDetail> builder)
        {
            builder.HasKey(x => x.PaymentDetailId);
            builder.Property(x => x.CardOwnerName).HasMaxLength(100);
            builder.Property(x => x.CardNumber).HasMaxLength(16);
            builder.Property(x => x.ExpirationDate).HasMaxLength(5);
            builder.Property(x => x.SecurityCode).HasMaxLength(3);
        }
    }
}
