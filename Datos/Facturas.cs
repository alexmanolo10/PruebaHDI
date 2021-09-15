using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class Facturas
    {
        private Conexion conexion = new Conexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar(int IdCiudad)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = String.Concat("SELECT F.IdFactura, F.Fecha, F.IdVendedor, V.IdCiudad " +
                                                "FROM dbo.FACTURAS F " +
                                                "   INNER JOIN dbo.Vendedores V ON F.IdVendedor = V.IdVendedor AND IdCiudad = ", IdCiudad);
            leer = comando.ExecuteReader();
            tabla.Clear();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }
    }
}
