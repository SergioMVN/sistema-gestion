using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    //    CREATE TABLE Permisos(
    //    id INT IDENTITY(1,1) PRIMARY KEY,
    //    usuario_id INT NOT NULL,
    //    pagina_id INT NOT NULL,
    //    FOREIGN KEY(usuario_id) REFERENCES Usuarios(id),
    //    FOREIGN KEY(pagina_id) REFERENCES Paginas(id)
    //);
    public class Permisos
    {
        public int id { get; set; }
        public int usuario_id { get; set; }
        public int pagina_id { get; set; }

        public Usuarios Usuario { get; set; }
        public Paginas Pagina { get; set; }
    }
}
