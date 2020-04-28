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
    
    public partial class Fbusquedaproductos : Form
    {
        ConexionDB objConexion = new ConexionDB();
        public int _idproducto;
        public Fbusquedaproductos()
        {
            InitializeComponent();
            grdBusquedaproductos.DataSource = objConexion.Obtener_datos().Tables["productos"].DefaultView; 
        }
        private void btnseleccionar_Click(object sender, EventArgs e)
        {
            if (grdBusquedaproductos.RowCount > 0)
            {
                _idproducto = int.Parse(grdBusquedaproductos.CurrentRow.Cells["idprodcuto"].Value.ToString());
                Close();
            }
            else
            {
                MessageBox.Show("NO hay datos que seleccionar", "Busqueda de Empleados",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btncancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            Filtrar_datos(txtbuscar.Text);
        }

        void Filtrar_datos(String valor)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = grdBusquedaproductos.DataSource;
            bs.Filter = "categoria like '%" + valor + "%' or codigo like '%" + valor + "%' or nombre like '%" + valor + "%'";
            grdBusquedaproductos.DataSource = bs;
        }
        
    }
}
