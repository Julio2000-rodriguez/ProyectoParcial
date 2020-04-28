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
    public partial class Fproductos_categorias : Form
    {
        ConexionDB objConexion = new ConexionDB();
        int posicion = 0;
        string accion = "Nuevo";
        DataTable tbl = new DataTable();
        public Fproductos_categorias()
        {
            InitializeComponent();
        }
        private void Fproductos_categorias_Load(object sender, EventArgs e)
        {
            ActualizarDs();
            MostrarDatos();
        }
        void ActualizarDs()
        {
            tbl = objConexion.Obtener_datos().Tables["productos"];
            tbl.PrimaryKey = new DataColumn[] { tbl.Columns["idproducto"] };
        }
        void MostrarDatos()
        {
            try
            {
                cboCategoriaProductos.DataSource = objConexion.Obtener_datos().Tables["categorias"];
                cboCategoriaProductos.DisplayMember = "categoria";
                cboCategoriaProductos.ValueMember = "categorias.idcategoria";
                cboCategoriaProductos.SelectedValue = tbl.Rows[posicion].ItemArray[1].ToString();

                lblidproducto.Text = tbl.Rows[posicion].ItemArray[0].ToString();
                txtcodigo.Text = tbl.Rows[posicion].ItemArray[2].ToString();
                txtnombre.Text = tbl.Rows[posicion].ItemArray[3].ToString();
                txtdescripcion.Text = tbl.Rows[posicion].ItemArray[4].ToString();
                txtprecio.Text = tbl.Rows[posicion].ItemArray[5].ToString();
           
                lblnregistros.Text = (posicion + 1) + " de " + tbl.Rows.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No hay Datos que mostrar", "Registros de Productos",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar_cajas();
            }
        }
        void Limpiar_cajas()
        {
            txtcodigo.Text = "";
            txtnombre.Text = "";
            txtdescripcion.Text = "";
            txtprecio.Text = "";
        }
        void Controles(Boolean valor)
        {
            grbNavegacion.Enabled = valor;
            btneliminar.Enabled = valor;
            btnBuscar.Enabled = valor;
            grbDatosProductos.Enabled = !valor;
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (btnNuevo.Text == "Nuevo")
            {
                btnNuevo.Text = "Guardar";
                btnModificar.Text = "Cancelar";
                accion = "Nuevo";

                Limpiar_cajas();
                Controles(false);
            }
            else
            {
                String[] valores = {
                    lblidproducto.Text,
                    cboCategoriaProductos.SelectedValue.ToString(),
                    txtcodigo.Text,
                    txtnombre.Text,
                    txtdescripcion.Text,
                    txtprecio.Text,
                };

                objConexion.Mantenimiento_productos_categorias(valores, accion);
                ActualizarDs();
                posicion = tbl.Rows.Count - 1;
                MostrarDatos();

                Controles(true);

                btnNuevo.Text = "Nuevo";
                btnModificar.Text = "Modificar";
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (btnModificar.Text == "Modificar")
            {
                btnNuevo.Text = "Guardar";
                btnModificar.Text = "Cancelar";
                accion = "modificar";

                Controles(false);

                btnNuevo.Text = "Guardar";
                btnModificar.Text = "Cancelar";
            }
            else
            {
                Controles(true);
                MostrarDatos();

                btnNuevo.Text = "Nuevo";
                btnModificar.Text = "Modificar";
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Fbusquedaproductos frmBusquedaproductos = new Fbusquedaproductos();
            frmBusquedaproductos.ShowDialog();

            if (frmBusquedaproductos._idproducto > 0)
            {
                posicion = tbl.Rows.IndexOf(tbl.Rows.Find(frmBusquedaproductos._idproducto));
                MostrarDatos();
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Fmenu cambio = new Fmenu();
            this.Hide();
            cambio.ShowDialog();
            this.Close();
        }

        
    }
}
