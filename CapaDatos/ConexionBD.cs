using System;
using System.Configuration;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class ConexionBD
    {

        private string ObtenerCadenaDeConexion()
        {
            return ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString;
        }

        public void EjecutarConsulta()
        {
            string cadenaDeConexion = ObtenerCadenaDeConexion();
            using (SqlConnection connection = new SqlConnection(cadenaDeConexion))
            {
                // Tu código para interactuar con la base de datos
            }
        }
    }
}
