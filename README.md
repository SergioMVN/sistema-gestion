BASE DE DATOS VERSION 1.0


CREATE DATABASE SISTEMA_GESTION

USE SISTEMA_GESTION


-- Creación de la Tabla de Roles
-- Esta tabla almacenará los roles que pueden ser asignados a los usuarios.
CREATE TABLE Roles (
    id INT IDENTITY(1,1) PRIMARY KEY,
    nombre_rol VARCHAR(100) NOT NULL,
    fecha_creacion DATETIME DEFAULT GETDATE(),
    activo BIT DEFAULT 1
);

-- Creación de la Tabla de Usuarios
-- Esta tabla almacenará la información de los usuarios, incluyendo su rol y estado de actividad.
CREATE TABLE Usuarios (
    id INT IDENTITY(1,1) PRIMARY KEY,
    nombre VARCHAR(100) NOT NULL,
    email VARCHAR(100) NOT NULL UNIQUE,
    password VARCHAR(100) NOT NULL,
    fecha_creacion DATETIME DEFAULT GETDATE(),
    rol_id INT,
    activo BIT DEFAULT 1,
    FOREIGN KEY (rol_id) REFERENCES Roles(id)
);


-- Creación de la Tabla de Páginas
-- Esta tabla almacenará las páginas y sus relaciones jerárquicas (padre/hija).
CREATE TABLE Paginas (
    id INT IDENTITY(1,1) PRIMARY KEY,
    nombre VARCHAR(100) NOT NULL,
    url VARCHAR(255) NOT NULL,
    es_padre BIT DEFAULT 0,
    id_padre INT NULL,
    FOREIGN KEY (id_padre) REFERENCES Paginas(id)
);


-- Creación de la Tabla de Permisos
-- Esta tabla vinculará las páginas con los usuarios, indicando qué usuario tiene acceso a qué página.
CREATE TABLE Permisos (
    id INT IDENTITY(1,1) PRIMARY KEY,
    usuario_id INT NOT NULL,
    pagina_id INT NOT NULL,
    FOREIGN KEY (usuario_id) REFERENCES Usuarios(id),
    FOREIGN KEY (pagina_id) REFERENCES Paginas(id)
);

-- Inserciones en la Tabla de Roles
-- Inserta roles predefinidos en la tabla de roles.
INSERT INTO Roles (nombre_rol) VALUES
('Administrador'),
('Editor'),
('Usuario');

-- Inserciones en la Tabla de Usuarios
-- Inserta usuarios con sus respectivos roles.
INSERT INTO Usuarios (nombre, email, password, rol_id) VALUES
('Juan Perez', 'juan@example.com', 'password123', 1), -- Juan es Administrador
('Maria Lopez', 'maria@example.com', 'password456', 3); -- Maria es Usuario

-- Inserciones en la Tabla de Páginas
-- Inserta páginas en la tabla de páginas, definiendo la jerarquía de las mismas.
INSERT INTO Paginas (nombre, url, es_padre, id_padre) VALUES
('Inicio', '/inicio', 1, NULL),
('Acerca de', '/acerca-de', 1, NULL),
('Contacto', '/contacto', 0, NULL);

-- Verificar que la página 'Acerca de' tiene ID 2 antes de insertar 'Nuestro Equipo'
-- Supone que las IDs se generan en orden de inserción
INSERT INTO Paginas (nombre, url, es_padre, id_padre) VALUES
('Nuestro Equipo', '/nuestro-equipo', 0, 2); -- 2 es el id de 'Acerca de'

-- Inserciones en la Tabla de Permisos
-- Inserta permisos para vincular usuarios con páginas y definir su acceso.
INSERT INTO Permisos (usuario_id, pagina_id) VALUES
(1, 1), -- Juan tiene acceso a Inicio
(1, 2), -- Juan tiene acceso a Acerca de
(2, 2), -- Maria tiene acceso a Acerca de
(2, 4); -- Maria tiene acceso a Nuestro Equipo


select * from Usuarios
select * from Roles
select * from Paginas
