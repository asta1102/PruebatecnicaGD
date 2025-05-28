using System;
using System.ComponentModel.DataAnnotations;

namespace EvaluacionWeb.Models
{
    public class Venta
    {
        [Key]
        public int CodigoVenta { get; set; }

        public DateTime Fecha { get; set; }

        public int ProductoCodigoProducto { get; set; }
        public Producto Producto { get; set; }
    }
}
