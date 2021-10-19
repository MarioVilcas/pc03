using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace pc3b.Models
{
    public class ProductoContext : DbContext
    {
        public DbSet<Producto> Productos { get; set; }
        

        public ProductoContext(DbContextOptions dco) : base(dco) {
            
        }
    }
}