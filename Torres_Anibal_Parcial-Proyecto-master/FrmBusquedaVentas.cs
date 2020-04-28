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
    public partial class FrmBusquedaVentas : Form
    {
        ConexionDB objConexion = new ConexionDB();
        public int _idventas;
        public FrmBusquedaVentas()
        {
            InitializeComponent();
            grdBusquedaClientes.DataSource = objConexion.Obtener_datos().Tables["Ventas"].DefaultView;
        }

        public object _IdVentas { get; internal set; }
        public int IdVentas { get; internal set; }

        private void btnseleccionar_Click(object sender, EventArgs e)
        {
            if (grdBusquedaClientes.RowCount > 0)
            {
                _idventas = int.Parse(grdBusquedaClientes.CurrentRow.Cells["idventas"].Value.ToString());
                Close();
            }
            else
            {
                MessageBox.Show("NO hay datos que seleccionar", "Busqueda de ventas",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void lblbuscar_Click(object sender, EventArgs e)
        {

        }
    }
}
