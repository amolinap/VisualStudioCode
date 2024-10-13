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
        public async Task<ActionResult<ICollection<Producto>>> Post(ICollection<Producto> detalleVenta)
        {
            //Venta venta = new Venta();
            DetalleVenta detalle = new DetalleVenta();

            //venta.Id_Ven = detalleVenta.Id_Ven;

            double total = 0;

            foreach(Producto id_pro in detalleVenta)
            {
                var producto = await _context.Productos.FindAsync(id_pro.Id_Pro);

                if(producto != null)
                {
                    //detalle.Producto = producto;
                    detalle.Productos.Add(producto.Id_Pro);
                    total += producto.Precio;

                    //_context.Add(detalle);
                    //_context.Entry(detalle.Venta).State = EntityState.Unchanged;
                    //await _context.SaveChangesAsync();
                }
            }
            //detalle.Productos = detalleVenta.Productos;
            detalle.Venta.Total = total;

            //_context.Add(venta);

            //detalle.Venta.Id_Ven = venta.Id_Ven;

            _context.Add(detalle);
            await _context.SaveChangesAsync();

            //return new CreatedAtRouteResult("GetProducto", new {id=venta.Id_Ven}, venta);
            return new CreatedAtRouteResult("GetDetalleVenta", new {id=detalle.Id_Det}, detalle);
        }
    }
}
