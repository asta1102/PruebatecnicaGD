using EvaluacionWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace EvaluacionWeb.Pages
{
    public class CategoriaModel : PageModel
    {
        private readonly AppDbContext _context;

        public CategoriaModel(AppDbContext context)
        {
            _context = context;
        }

        // Lista desplegable de categorías
        public List<SelectListItem> CategoriaSelectList { get; set; } = new();

        // Productos que se mostrarán
        public List<Producto> ProductoFiltrado { get; set; } = new();

        [BindProperty(SupportsGet = true)]
        public int CategoriaSeleccionadaId { get; set; }

        public void OnGet()
        {
            // 1. Cargar categorías que tuvieron ventas en 2019
            CategoriaSelectList = _context.Categoria
                .Where(c => c.Producto.Any(p => p.Venta.Any(v => v.Fecha.Year == 2019)))
                .Select(c => new SelectListItem
                {
                    Value = c.CodigoCategoria.ToString(),
                    Text = c.Nombre
                })
                .ToList();

            // 2. Si hay categoría seleccionada, mostrar sus productos vendidos en 2019
            if (CategoriaSeleccionadaId != 0)
            {
                ProductoFiltrado = _context.Producto
                    .Where(p => p.CategoriaCodigoCategoria == CategoriaSeleccionadaId &&
                                p.Venta.Any(v => v.Fecha.Year == 2019))
                    .Include(p => p.Venta)
                    .ToList();
            }
        }
    }
}
