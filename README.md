Prueba Técnica - Desarrollador .NET / C# Jr.

Este proyecto es parte de una prueba técnica para el puesto de Desarrollador .NET/C# Jr. Consiste en:

1. Consulta SQL para obtener el nombre de la categoría del producto de la última venta registrada por fecha.
2. Aplicación Web ASP.NET Core Razor Pages para listar los productos vendidos en el año 2019, filtrables por categoría.

---

 Estructura del Repositorio
PruebatecnicaGD
base de datos
onsulta ultima venta registrada.sql
Script-5.sql (esquema, datos y relaciones)
EvaluacionWeb/ (solución ASP.NET Core Razor Pages)
Models
Pages
Categorias.cshtml
Categorias.cshtml.cs
Index.cshtml
README.md
┗Documentacion_Prueba_Tecnica.pdf




Tecnologías Utilizadas

- ASP.NET Core Razor Pages
- Entity Framework Core
- C#
- LINQ
- SQL Server
- Bootstrap (para estilos básicos)



Lógica Implementada

 Parte A: Consulta SQL
Consulta que devuelve el nombre de la categoría del producto con la última venta según la fecha.

sql
SELECT TOP 1 c.Nombre AS Categoria
FROM Venta v
INNER JOIN Producto p ON v.CodigoProducto = p.CodigoProducto
INNER JOIN Categoria c ON p.CodigoCategoria = c.CodigoCategoria
ORDER BY v.Fecha DESC;

Parte B: Aplicación Web
Se muestran únicamente las categorías con ventas en 2019.

Al seleccionar una categoría, se listan los productos de dicha categoría vendidos en ese año.

Se utiliza LINQ para filtrar y obtener los datos.

git clone https://github.com/asta1102/PruebatecnicaGD.git

Abre la solución EvaluacionWeb.sln en Visual Studio.

Asegúrate de tener configurado un SQL Server y restaura la base de datos con el archivo Script-5.sql.

Ajusta la cadena de conexión en appsettings.json según tu entorno.

Ejecuta el proyecto.

Autor
Kenneth Muñoz
GitHub: asta1102


