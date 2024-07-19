using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    //    CREATE TABLE Roles(
    //    id INT IDENTITY(1,1) PRIMARY KEY,
    //    nombre_rol VARCHAR(100) NOT NULL,
    //    fecha_creacion DATETIME DEFAULT GETDATE(),
    //    activo BIT DEFAULT 1
    //);

    public class Roles
    {
        public int id { get; set; }
        public string nombre_rol { get; set; }
        public DateTime fechacreacion { get; set; }
        public bool activo { get; set; }

        // Propiedad de navegación opcional
        public ICollection<Usuarios> Usuarios { get; set; }

    }
}
