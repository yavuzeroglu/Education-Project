using Education.Persistance.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Education.Persistance
{
    public class DesingTimeDbContextFactory : IDesignTimeDbContextFactory<EducationDbContext>
    {
        public EducationDbContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<EducationDbContext> dbContextOptionsBuilder = new();
            dbContextOptionsBuilder.UseSqlServer(ConfigurationHelper.ConnectionString);
            return new(dbContextOptionsBuilder.Options);
        }
    }
}
