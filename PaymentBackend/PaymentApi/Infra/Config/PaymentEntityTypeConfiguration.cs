using Microsoft.EntityFrameworkCore;

namespace PaymentApi.Context.Config
{
    public interface PaymentEntityTypeConfiguration<T> : IEntityTypeConfiguration<T> where T : class
    {
 
    }
}
