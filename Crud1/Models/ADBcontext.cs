using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data;
using Microsoft.EntityFrameworkCore;

namespace Crud1.Models
{
    public class ADBcontext : DbContext
    {
        public ADBcontext(DbContextOptions<ADBcontext>options):base(options)
        {

        }

        public DbSet<Ninio> Ninio { get; set; }
        public DbSet<Tutor> Tutor { get; set; }
    }
}
