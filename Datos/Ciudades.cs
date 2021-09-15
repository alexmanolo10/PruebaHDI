using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class Ciudades
    {
        private Conexion conexion = new Conexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar( int IdEstado )
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = String.Concat("SELECT IdCiudad, NOMBRE FROM dbo.CIUDADES WHERE IdEstado = ", IdEstado, " ");
            leer = comando.ExecuteReader();
            tabla.Clear();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }
    }
}
