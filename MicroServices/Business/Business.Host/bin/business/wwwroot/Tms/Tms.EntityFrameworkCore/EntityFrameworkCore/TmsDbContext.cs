using Tms.Models;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Tms.EntityFrameworkCore
{
    [ConnectionStringName("Tms")]
    public class TmsDbContext : AbpDbContext<TmsDbContext>
    {
        public DbSet<Car> Car { get; set; }

        //Code generation...

        public TmsDbContext(DbContextOptions<TmsDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ConfigureTms();
        }
    }
}
