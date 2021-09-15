using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Datos;

namespace Negocio
{
    public class Ciudades
    {
        private Datos.Ciudades datos_ciudades = new Datos.Ciudades();

        public DataTable MostrarCiudades( int IdEstado )
        {
            DataTable tabla = new DataTable();
            tabla = datos_ciudades.Mostrar(IdEstado);
            return tabla;
        }
    }
}
