using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiTest
{
    public class Venta
    {
        [Key]
        public int Id_Ven { get; set; }

        public double Total { get; set; }

        public int Status { get; set; }

    }
}