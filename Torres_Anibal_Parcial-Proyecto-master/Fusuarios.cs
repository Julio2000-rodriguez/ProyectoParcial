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
    public partial class Fusuarios : Form
    {
        ConexionDB objConexion = new ConexionDB();
        int posicion = 0;

        public string accion = "Nuevo";
        DataTable tbl = new DataTable();
        public Fusuarios()
        {
            InitializeComponent();
        }
        void ActualizarDs()
        {
            tbl = objConexion.Obtener_datos().Tables["usuarios"];
            tbl.PrimaryKey = new DataColumn[] { tbl.Columns["idusuario"] };
            MostrarDatos();
        }
        void MostrarDatos()
        {
            try
            {
                lblidusuario.Text = tbl.Rows[posicion].ItemArray[0].ToString();
                txtcodigo.Text = tbl.Rows[posicion].ItemArray[1].ToString();
                txtnombre.Text = tbl.Rows[posicion].ItemArray[2].ToString();
                txtapellido.Text = tbl.Rows[posicion].ItemArray[3].ToString();
                txtdireccion.Text = tbl.Rows[posicion].ItemArray[4].ToString();
                txtdui.Text = tbl.Rows[posicion].ItemArray[5].ToString();
                txttelefono.Text = tbl.Rows[posicion].ItemArray[6].ToString();

                lblnregistros.Text = (posicion + 1) + " de " + tbl.Rows.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No hay Datos que mostrar", "Registros de usuario",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar_cajas();
            }
        }
        void Limpiar_cajas()
        {
            txtcodigo.Text = "";
            txtnombre.Text = "";
            txtapellido.Text = "";
            txtdireccion.Text = "";
            txtdui.Text = "";
            txttelefono.Text = "";
        }
        void Controles(Boolean valor)
        {
            grbNavegacion.Enabled = valor;
            btneliminar.Enabled = valor;
            btnBuscar.Enabled = valor;
            grbDatosUsuarios.Enabled = !valor;
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
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
                    lblidusuario.Text,
                    txtcodigo.Text,
                    txtnombre.Text,
                    txtapellido.Text,
                    txtdireccion.Text,
                    txtdui.Text,
                    txttelefono.Text,
                };
                objConexion.Mantenimiento_usuarios(valores, accion);
                ActualizarDs();
                posicion = tbl.Rows.Count - 1;
                MostrarDatos();

                Controles(true);

                btnNuevo.Text = "Nuevo";
                btnModificar.Text = "Modificar";
            }
        }
        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (btnModificar.Text == "Modificar")
            {
                btnNuevo.Text = "Guardar";
                btnModificar.Text = "Cancelar";
                accion = "Modificar";

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
        private void Btneliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de elimina a " + txtnombre.Text, "Registro de Clientes",
               MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                String[] valores = { lblidusuario.Text };
                objConexion.Mantenimiento_usuarios(valores, "Eliminar");

                ActualizarDs();
                posicion = posicion > 0 ? posicion - 1 : 0;
                MostrarDatos();
            }
        }
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            Fbusquedausuarios frmBusquedausuarios = new Fbusquedausuarios();
            frmBusquedausuarios.ShowDialog();

            if (frmBusquedausuarios._idusuario > 0)
            {
                posicion = tbl.Rows.IndexOf(tbl.Rows.Find(frmBusquedausuarios._idusuario));
                MostrarDatos();
            }
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            Fmenu cambio = new Fmenu();
            this.Hide();
            cambio.ShowDialog();
            this.Close();
        }

        private void btnprimero_Click(object sender, EventArgs e)
        {
            posicion = 0;
            MostrarDatos();
        }

        private void btnultimo_Click(object sender, EventArgs e)
        {
            posicion = tbl.Rows.Count - 1;
            MostrarDatos();
        }

        private void btnanterior_Click(object sender, EventArgs e)
        {
            if (posicion > 0)
            {
                posicion--;
                MostrarDatos();
            }
            else
            {
                MessageBox.Show("Primer Registro...", "Registros de Cliente",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnsiguiente_Click(object sender, EventArgs e)
        {
            if (posicion < tbl.Rows.Count - 1)
            {
                posicion++;
                MostrarDatos();
            }
            else
            {
                MessageBox.Show("Ultimo Registro...", "Registros de Cliente",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
