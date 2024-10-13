using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiTest
{
    public class Venta
    {
        public Venta()
        {
            Id_Ven = 0;
            Total = 0.0;
            Status = 1;
        }

        [Key]
        public int Id_Ven { get; set; }

        public double Total { get; set; }

        public int Status { get; set; }

    }
}