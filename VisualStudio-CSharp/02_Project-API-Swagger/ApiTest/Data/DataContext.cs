using System;
using Microsoft.EntityFrameworkCore;

namespace ApiTest
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
        : base(options)
        {
            
        }

        public DbSet<Producto> Productos {get; set;}
    }
}