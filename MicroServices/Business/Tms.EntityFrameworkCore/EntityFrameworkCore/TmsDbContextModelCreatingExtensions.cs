using Tms.Models;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Tms.EntityFrameworkCore
{
    public static class TmsDbContextModelCreatingExtensions
    {
        public static void ConfigureTms(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            builder.Entity<Car>(b =>
            {
                b.ToTable("cars");

                b.ConfigureByConvention();
                
                b.Property(x => x.Code).IsRequired();
                b.Property(x => x.Name).IsRequired();
            });

            //Code generation...
        }
    }
}
