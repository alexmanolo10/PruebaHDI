using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace Presentacion
{
    public partial class Form1 : Form
    {
        Estados estados = new Estados();
        Ciudades ciudades = new Ciudades();
        Facturas facturas = new Facturas();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarEstados();
        }

        private void MostrarEstados()
        {
            dataGridViewEstados.DataSource = estados.MostrarEstados();
        }

        private void MostrarCiudades(int IdEstado)
        {
            dataGridViewCiudades.DataSource = ciudades.MostrarCiudades(IdEstado);
        }

        private void MostrarFacturas(int IdCiudad)
        {
            dataGridViewFacturas.DataSource = facturas.MostrarFacturas(IdCiudad);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String msg = "Seleccionaste el estado de ";
            
            MessageBox.Show(msg + (String) dataGridViewEstados.CurrentRow.Cells[1].Value);
            
            MostrarCiudades((int)dataGridViewEstados.CurrentRow.Cells[0].Value);
        }

        private void dataGridViewCiudades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MostrarFacturas((int)dataGridViewCiudades.CurrentRow.Cells[0].Value);
        }
    }
}
