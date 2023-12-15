using Microsoft.EntityFrameworkCore;
using OnionExample.Application.Interfaces.Context;
using OnionExample.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionExample.Persistence.Context
{
    public class ApplicationDbContext : DbContext, IApplicationContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) 
        {
            
        }
        public DbSet<Product> Products { get ; set ; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                
                new Product {Id = Guid.NewGuid(), Name="p1",Description="d1", Price=10, Stock=100 },
                new Product {Id = Guid.NewGuid(), Name="p2",Description="d2", Price=20, Stock=200 },
                new Product {Id = Guid.NewGuid(), Name="p3",Description="d3", Price=30, Stock=300 },
                new Product {Id = Guid.NewGuid(), Name="p4",Description="d4", Price=40, Stock=400 }
                
                );
        }
    }
}
