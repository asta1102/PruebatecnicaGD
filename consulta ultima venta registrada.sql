SELECT c.Nombre AS NombreCategoria
FROM Venta v
JOIN Producto p ON v.ProductoId = p.Id
JOIN Categoria c ON p.CategoriaId = c.Id
WHERE v.Fecha = (
    SELECT MAX(Fecha)
    FROM Venta
);
