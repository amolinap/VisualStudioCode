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
    public class DetalleVentaController : ControllerBase
    {
        private readonly ILogger<DetalleVentaController> _logger;
        private readonly DataContext _context;

        public DetalleVentaController(ILogger<DetalleVentaController> logger, DataContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet(Name = "GetDetalleVentas")]
        public async Task<ActionResult<IEnumerable<DetalleVenta>>> GetDetalleVentas()
        {
            return await _context.DetalleVenta.ToListAsync();
        }

        [HttpGet("{id}", Name = "GetDetalleVenta")]
        public async Task<ActionResult<DetalleVenta>> GetDetalleVenta(int id)
        {
            var producto = await _context.DetalleVenta.FindAsync(id);

            if(producto == null)
            {
                return NotFound();
            }

            return producto;
        }
    }
}
