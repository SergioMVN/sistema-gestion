using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Modelos
{
//    CREATE TABLE Paginas(
//    id INT IDENTITY(1,1) PRIMARY KEY,
//    nombre VARCHAR(100) NOT NULL,
//    url VARCHAR(255) NOT NULL,
//    es_padre BIT DEFAULT 0,
//    id_padre INT NULL,
//    FOREIGN KEY(id_padre) REFERENCES Paginas(id)
//);

    public class Paginas
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string url { get; set; }
        public bool es_padre { get; set; }
        public int id_padre { get; set; }

        // Propiedad de navegación opcional para referencias a la misma entidad
        public Paginas Padre { get; set; }
        public ICollection<Paginas> Hijos { get; set; }
    }
}
