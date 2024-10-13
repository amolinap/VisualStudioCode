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

        public DbSet<Venta> Ventas {get; set;}

        public DbSet<DetalleVenta> DetalleVenta {get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<DetalleVenta>().HasMany(p => p.Productos).WithOne(b => b.DetalleVenta).HasForeignKey(p => p.producto);
        }
    }
}