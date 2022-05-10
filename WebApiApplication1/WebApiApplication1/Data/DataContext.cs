using Microsoft.EntityFrameworkCore;
using WebApiApplication1.Domains;

namespace WebApiApplication1.Data
{
    public class DataContext: DbContext
    {  
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<Inspection> Inspections { get; set; }

        public DbSet<Status> Status { get; set; }

        public DbSet<InspectionType> InspectionTypes { get; set; }
    }
}
