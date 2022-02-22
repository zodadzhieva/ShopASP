using ASPshop.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPshop.Data
{
    public class ShopContext : DbContext
    {


        public ShopContext()
        {

        }

        public ShopContext(DbContextOptions<ShopContext> options) :
            base(options)
        {

        }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Order> Order { get; set; }
    }
}
