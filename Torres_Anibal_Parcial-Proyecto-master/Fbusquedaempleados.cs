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
    public partial class Fbusquedaempleados : Form
    {
        ConexionDB objConexion = new ConexionDB();
        public int _idempleado;
        public Fbusquedaempleados()
        {
            InitializeComponent();
            grdBusquedaempleados.DataSource = objConexion.Obtener_datos().Tables["empleados"].DefaultView;
        }

        private void Btnseleccionar_Click(object sender, EventArgs e)
        {
            if (grdBusquedaempleados.RowCount > 0)
            {
                _idempleado = int.Parse(grdBusquedaempleados.CurrentRow.Cells["idempleado"].Value.ToString());
                Close();
            }
            else
            {
                MessageBox.Show("NO hay datos que seleccionar", "Busqueda de Empleados",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Btncancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Txtbuscar_TextChanged(object sender, EventArgs e)
        {
            Filtrar_datos(txtbuscar.Text);
        }
        void Filtrar_datos(String valor)
        {
            BindingSource ds = new BindingSource();
            ds.DataSource = grdBusquedaempleados.DataSource;
            ds.Filter = "codigo like '%" + valor + "%'";
            ds.Filter = "nombre like '%" + valor + "%'";
            ds.Filter = "descripcion like '%" + valor + "%'";
            grdBusquedaempleados.DataSource = ds;
        }
    }
}
