using Contoso.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Contoso.API.Data
{
    public class ContosoContext : DbContext
    {
        public ContosoContext(DbContextOptions<ContosoContext> options)
            : base(options)
        {
        }

        public DbSet<ContosoData> ContosoData { get; set; }
    }
}
