-- Script de creacion de base de datos y login correspondiente.
-- Se puede ejecutar todo el script sin intervencion.
-- BORRARA LA BASE DE DATOS LLAMADA 'sistema_factura'
USE master;

IF EXISTS (SELECT name FROM sys.databases WHERE name = 'sistema_factura')
BEGIN
    USE master;
    ALTER DATABASE sistema_factura SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE sistema_factura;
END
GO

CREATE DATABASE sistema_factura;
GO

USE sistema_factura;

CREATE TABLE usuario(
    nit				BIGINT PRIMARY KEY NOT NULL,
    nombre			VARCHAR(50),
);
GO

CREATE TABLE factura(
    id_factura			INT IDENTITY (1,1) PRIMARY KEY NOT NULL,
    nit_usuario			BIGINT NOT NULL,
    nombre_razon        VARCHAR(100), -- Probablemente no se llene
    nit_emisor			BIGINT NOT NULL,
    numero_factura		INT NOT NULL,
    cod_autorizacion	VARCHAR(70)NOT NULL,
    fecha_emision		DATE NOT NULL,
    monto				MONEY NOT NULL,
    monto_imponible		MONEY NOT NULL,
    cod_control     	VARCHAR(30), -- Probablemente no tiene
    tipo_especifico     BIT NOT NULL,
    tipo_general        BIT NOT NULL,
    FOREIGN KEY (nit_usuario) REFERENCES usuario(nit),
);
GO

USE master;
IF EXISTS (SELECT * FROM sys.server_principals WHERE name = 'factura_admin')
BEGIN
    DROP LOGIN factura_admin;
END
GO
CREATE LOGIN factura_admin WITH PASSWORD = 'admin123', CHECK_POLICY = OFF;
GO
USE sistema_factura;
DROP USER IF EXISTS factura_admin;
GO
CREATE USER factura_admin FOR LOGIN factura_admin;
GO
ALTER USER factura_admin WITH DEFAULT_SCHEMA = [dbo];
ALTER ROLE [db_owner] ADD MEMBER factura_admin;
GO