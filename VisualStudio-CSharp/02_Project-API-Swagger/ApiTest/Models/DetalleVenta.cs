using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiTest
{
    public class DetalleVenta
    {
        public DetalleVenta()
        {
            Productos = new List<int>();
        }

        [Key]
        public int Id_Det { get; set; }
        
        //[ForeignKey("Id_Ven")]
        public Venta Venta { get; set; }

        //[ForeignKey("Id_Pro")]
        public ICollection<int> Productos { get; set; }

    }
}