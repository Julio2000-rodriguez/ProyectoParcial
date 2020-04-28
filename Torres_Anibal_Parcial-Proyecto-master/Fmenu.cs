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
    public partial class Fmenu : Form
    {
        public Fmenu()
        {
            InitializeComponent();
        }

        private void BtnCliente_Click(object sender, EventArgs e)
        {
            Fusuarios cambio = new Fusuarios();
            this.Hide();
            cambio.ShowDialog();
            this.Close();
        }

        private void BtnProducto_Click(object sender, EventArgs e)
        {
            Fproductos_categorias cambio = new Fproductos_categorias();
            this.Hide();
            cambio.ShowDialog();
            this.Close();
        }

        private void BtnEmpleado_Click(object sender, EventArgs e)
        {
            Fempleados cambio = new Fempleados();
            this.Hide();
            cambio.ShowDialog();
            this.Close();
        }
          
        private void BtnVenta_Click(object sender, EventArgs e)
        {
            
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMateriales_Click(object sender, EventArgs e)
        {
            Fproveedores cambio = new Fproveedores();
            this.Hide();
            cambio.ShowDialog();
            this.Close();
        }
    }
}
