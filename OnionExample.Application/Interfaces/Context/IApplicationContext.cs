using Microsoft.EntityFrameworkCore;
using OnionExample.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionExample.Application.Interfaces.Context
{
    public interface IApplicationContext
    {
        public DbSet<Product> Products { get; set; }
    }
}
