using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ASPshop.Data;

namespace ASPshop.Data
{
    public class ASPshopContext : DbContext
    {
        public ASPshopContext (DbContextOptions<ASPshopContext> options)
            : base(options)
        {
        }

        public DbSet<ASPshop.Data.Product> Product { get; set; }

        public DbSet<ASPshop.Data.User> User { get; set; }
    }
}
