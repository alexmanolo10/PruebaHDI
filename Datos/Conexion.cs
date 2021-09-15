using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class Conexion
    {
        private SqlConnection ConexionBD = new SqlConnection("Server=DESKTOP-2RHCKAG\\SQLEXPRESS;DataBase=PRUEBAHDI;Integrated Security=true");

        public SqlConnection AbrirConexion()
        {
            if (ConexionBD.State == ConnectionState.Closed)
                ConexionBD.Open();
            return ConexionBD;
        }

        public SqlConnection CerrarConexion()
        {
            if (ConexionBD.State == ConnectionState.Closed)
                ConexionBD.Close();
            return ConexionBD;
        }
    }
}
