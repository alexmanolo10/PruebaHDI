using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Datos;

namespace Negocio
{
    public class Facturas
    {
        private Datos.Facturas datos_facturas = new Datos.Facturas();

        public DataTable MostrarFacturas(int IdCiudad)
        {
            DataTable tabla = new DataTable();
            tabla = datos_facturas.Mostrar(IdCiudad);
            return tabla;
        }
    }
}
