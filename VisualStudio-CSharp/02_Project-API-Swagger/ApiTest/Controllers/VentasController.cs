using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using ApiTest;
using Microsoft.EntityFrameworkCore;

namespace ApiTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VentasController : ControllerBase
    {
        private readonly ILogger<VentasController> _logger;
        private readonly DataContext _context;

        public VentasController(ILogger<VentasController> logger, DataContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet(Name = "GetVentas")]
        public async Task<ActionResult<IEnumerable<Venta>>> GetVentas()
        {
            return await _context.Ventas.ToListAsync();
        }

        [HttpGet("{id}", Name = "GetVenta")]
        public async Task<ActionResult<Venta>> GetVenta(int id)
        {
            var venta = await _context.Ventas.FindAsync(id);

            if(venta == null)
            {
                return NotFound();
            }

            return venta;
        }

        [HttpPost]
        public async Task<ActionResult<Venta>> Post(DetalleVenta detalleVenta)
        {
            Venta venta = new Venta();
            DetalleVenta detalle = new DetalleVenta();

            venta.Id_Ven = detalleVenta.Venta.Id_Ven;

            double total = 0;

            foreach(int id_pro in detalleVenta.Productos)
            {
                var producto = await _context.Productos.FindAsync(id_pro);

                if(producto != null)
                {
                    detalle.Productos.Add(producto.Id_Pro);
                    total += producto.Precio;
                }
            }
            //detalle.Productos = detalleVenta.Productos;
            venta.Total = total;

            _context.Add(venta);
            _context.Add(detalle);
            await _context.SaveChangesAsync();

            return new CreatedAtRouteResult("GetProducto", new {id=venta.Id_Ven}, venta);
        }
    }
}
