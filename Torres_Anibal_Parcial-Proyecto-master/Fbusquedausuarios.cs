using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Torres_Anibal_Parcial
{
    public partial class Fbusquedausuarios : Form
    {
        ConexionDB objConexion = new ConexionDB();
        public int _idusuario;
        public Fbusquedausuarios()
        {
            InitializeComponent();
            grdBusquedaClientes.DataSource = objConexion.Obtener_datos().Tables["usuarios"].DefaultView;
        }

        private void Btnseleccionar_Click(object sender, EventArgs e)
        {
            if (grdBusquedaClientes.RowCount > 0)
            {
                _idusuario = int.Parse(grdBusquedaClientes.CurrentRow.Cells["idusuario"].Value.ToString());
                Close();
            }
            else
            {
                MessageBox.Show("NO hay datos que seleccionar", "Busqueda de Usuarios",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Btncancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Txtbuscar_TextChanged(object sender, EventArgs e)
        {
            FiltrarDatos(txtbuscar.Text);
        }
        void FiltrarDatos(String valor)
        {

            BindingSource bs = new BindingSource();
            bs.DataSource = grdBusquedaClientes.DataSource;
            bs.Filter = "nombre like '%" + valor + "%'";
            bs.Filter = "direccion like '%" + valor + "%'";
            bs.Filter = "codigo like '%" + valor + "%'";
            bs.Filter = "apellido like '%" + valor + "%'";
            grdBusquedaClientes.DataSource = bs;
        }

        private void grdBusquedaClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
