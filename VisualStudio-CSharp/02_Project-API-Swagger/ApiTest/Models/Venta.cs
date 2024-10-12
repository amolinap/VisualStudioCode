using System;
using System.ComponentModel.DataAnnotations;

namespace ApiTest
{
    public class Venta
    {
        [Key]
        public int Id_Ven { get; set; }

        public double Total { get; set; }

        public int Status { get; set; }

        public virtual ICollection<Producto> Producto { get; set; }

    }
}