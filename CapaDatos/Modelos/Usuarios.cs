using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Modelos
{
//    CREATE TABLE Usuarios(
//    id INT IDENTITY(1,1) PRIMARY KEY,
//    nombre VARCHAR(100) NOT NULL,
//    email VARCHAR(100) NOT NULL UNIQUE,
//    password VARCHAR(100) NOT NULL,
//    fecha_creacion DATETIME DEFAULT GETDATE(),
//    rol_id INT,
//    activo BIT DEFAULT 1,
//    FOREIGN KEY(rol_id) REFERENCES Roles(id)
//);

    public class Usuarios
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public DateTime fecha_creacion { get; set; }
        public int rol_id { get; set; }
        public bool activo { get; set; }

        // Propiedad de navegación opcional
        public Roles Rol { get; set; }
    }
}
