CREATE DATABASE EvaluacionDev;

USE EvaluacionDev;

-- Tabla: Categoria
CREATE TABLE Categoria (
    CodigoCategoria INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(100) NOT NULL
);

-- Tabla: Producto
CREATE TABLE Producto (
    CodigoProducto INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(100) NOT NULL,
    Precio DECIMAL(10,2) NOT NULL,
    CategoriaCodigoCategoria INT NOT NULL,
    FOREIGN KEY (CategoriaCodigoCategoria) REFERENCES Categoria(CodigoCategoria)
);

-- Tabla: Venta
CREATE TABLE Venta (
    CodigoVenta INT IDENTITY(1,1) PRIMARY KEY,
    Fecha DATETIME NOT NULL,
    ProductoCodigoProducto INT NOT NULL,
    FOREIGN KEY (ProductoCodigoProducto) REFERENCES Producto(CodigoProducto)
);






INSERT INTO Categoria (Nombre) VALUES
('Electrónica'),
('Hogar'),
('Ropa');



INSERT INTO Producto (Nombre, Precio, CategoriaCodigoCategoria) VALUES
('Televisor Samsung 50"', 4500.00, 1),
('Refrigeradora LG', 3800.00, 2),
('Camisa Polo', 200.00, 3),
('Laptop Dell', 7500.00, 1),
('Sofá de 3 plazas', 2700.00, 2);


INSERT INTO Venta (Fecha, ProductoCodigoProducto) VALUES
('20190115', 1),
('20190310', 2),
('20200605', 3),
('20191225', 4),
('20210708', 5);


SELECT * FROM venta;


SELECT * FROM Producto;

SELECT * FROM Categoria;

SELECT 
    c.Nombre AS Categoria,
    p.Nombre AS Producto,
    COUNT(v.CodigoVenta) AS Ventas

FROM Categoria c
INNER JOIN Producto p ON c.CodigoCategoria = p.CategoriaCodigoCategoria
INNER JOIN Venta v ON p.CodigoProducto = v.ProductoCodigoProducto
WHERE YEAR(v.Fecha) = 2019
GROUP BY c.Nombre, p.Nombre
ORDER BY c.Nombre, p.Nombre;




SELECT TOP 1 c.Nombre AS Categoria
FROM Venta v
JOIN Producto p ON v.ProductoCodigoProducto = p.CodigoProducto
JOIN Categoria c ON p.CategoriaCodigoCategoria = c.CodigoCategoria
ORDER BY v.Fecha DESC;

