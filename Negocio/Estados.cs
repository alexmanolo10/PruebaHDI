using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Datos;

namespace Negocio
{
    public class Estados
    {
        private Datos.Estados datos_estados = new Datos.Estados();

        public DataTable MostrarEstados()
        {
            DataTable tabla = new DataTable();
            tabla = datos_estados.Mostrar();
            return tabla;
        }
    }
}
