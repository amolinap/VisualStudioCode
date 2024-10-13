using System;
using System.ComponentModel.DataAnnotations;

namespace ApiTest
{
    public class Producto
    {
        public Producto()
        {
            Id_Pro =0;
            Nombre = "";
            NumSerie = "";
            Precio = 0.0;
            Status = 1;
        }

        [Key]
        public int Id_Pro { get; set; }

        public string Nombre { get; set; }

        public string NumSerie { get; set; }

        public double Precio { get; set; }

        public int Status { get; set; }

    }
}