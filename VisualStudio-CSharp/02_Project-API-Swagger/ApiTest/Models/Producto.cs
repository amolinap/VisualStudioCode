using System;
using System.ComponentModel.DataAnnotations;

namespace ApiTest
{
    public class Producto
    {
        [Key]
        public int Id_Pro { get; set; }

        public string NumControl { get; set; }

        public required string NumSerie { get; set; }

        public double Precio { get; set; }

        public int Status { get; set; }

    }
}