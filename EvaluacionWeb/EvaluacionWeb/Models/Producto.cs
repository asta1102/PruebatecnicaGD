using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EvaluacionWeb.Models
{
    public class Producto
    {
        [Key]
        public int CodigoProducto { get; set; }

        public string Nombre { get; set; }

        public decimal Precio { get; set; }

        public int CategoriaCodigoCategoria { get; set; }
        public Categoria Categoria { get; set; }

        public ICollection<Venta> Venta { get; set; }
    }
}
