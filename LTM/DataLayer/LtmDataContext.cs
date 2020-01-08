using Domain;
using Microsoft.EntityFrameworkCore;

namespace DataLayer
{
    public class LtmDataContext : DbContext, ILtmDataContext
    {
        public LtmDataContext(DbContextOptions<LtmDataContext> options)
            : base(options)
        {
        }

        public DbSet<Project> Projects { get; set; }

        public void Save()
        {
            SaveChanges();
        }
    }
}