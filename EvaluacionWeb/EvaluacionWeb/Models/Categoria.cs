using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EvaluacionWeb.Models
{
    public class Categoria
    {
        [Key] // 👈 ESTA LÍNEA ES FUNDAMENTAL
        public int CodigoCategoria { get; set; }

        public string Nombre { get; set; }

        // Relación uno a muchos: una categoría puede tener muchos productos
        public ICollection<Producto> Producto { get; set; }
    }
}
