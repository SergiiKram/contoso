using Contoso.API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
