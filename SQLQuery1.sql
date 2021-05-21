CREATE DATABASE DBClientes
GO
USE DBClientes
GO

CREATE TABLE Producto(
	Codigo varchar(6) primary key NOT NULL,
	Nombre varchar(50) NULL,
	Descripcion varchar(200) NULL,
	Costo decimal(8,2) NULL
)

INSERT INTO Producto values('PRO001',	'Laptop Pavilion 2en1 14" Core i7',	'Laptop Pavilion 2en1 14" Core i7 8GB RAM 1TB',	3329),
('PRO002',	'UDI RC - Drone U42W Wi-Fi FPV',	'Drone con c�mara y estabilizaci�n de altura',	400),
('PRO003',	'EPSON L575 IMPRESORA',	'Epson l575 impresora multifunci�nal tanque de tinta WiFi',	1374),
('PRO004',	'PLAYSTATION CONSOLA PS4',	'Sony PlayStation 4 Pro 1TB + Sony DualShock 4', 1999),
('PRO005',	'Camara IP D-Link Wireless', 'La c�mara IP D-Link Enhanced Wireless N Day/Night Home Network', 249)

select * from Producto