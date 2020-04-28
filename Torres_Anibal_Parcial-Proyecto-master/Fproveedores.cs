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
    public partial class Fproveedores : Form
    {
        ConexionDB objConexion = new ConexionDB();
        int posicion = 0;

        string accion="Nuevo";
        DataTable tblp = new DataTable();
        public Fproveedores()
        {
            InitializeComponent();
        }
        void ActualizarDs()
        {
            tblp = objConexion.Obtener_datos().Tables["proveedores"];
            tblp.PrimaryKey = new DataColumn[] { tblp.Columns["idproveedor"] };
            MostrarDatos();
        }
        void MostrarDatos()
        {
            try
            {
                lblidproducto.Text = tblp.Rows[posicion].ItemArray[0].ToString();
                txtcodigo.Text = tblp.Rows[posicion].ItemArray[1].ToString();
                txtnombreproveedor.Text = tblp.Rows[posicion].ItemArray[2].ToString();
                txtnombrecontacto.Text = tblp.Rows[posicion].ItemArray[3].ToString();
                txtdireccion.Text = tblp.Rows[posicion].ItemArray[4].ToString();
                txttelefono.Text = tblp.Rows[posicion].ItemArray[5].ToString();
                txtemail.Text = tblp.Rows[posicion].ItemArray[6].ToString();

                lblnregistros.Text = (posicion + 1) + " de " + tblp.Rows.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No hay Datos que mostrar", "Registros de Proveedores",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar_cajas();
            }
        }
        void Limpiar_cajas()
        {
            txtcodigo.Text = "";
            txtnombreproveedor.Text = "";
            txtnombrecontacto.Text = "";
            Txtcargo.Text = "";
            txtdireccion.Text = "";
            txttelefono.Text = "";
            txtemail.Text = "";
        }
        void Controles(Boolean valor)
        {
            grbNavegacion.Enabled = valor;
            btneliminar.Enabled = valor;
            btnBuscar.Enabled = valor;
            grbDatospanes.Enabled = !valor;
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
                    lblidproducto.Text,
                    txtcodigo.Text,
                    txtnombreproveedor.Text,
                    txtnombrecontacto.Text,
                    txtdireccion.Text,
                    txtemail.Text,
                };

                objConexion.Mantenimiento_proveedores(valores, accion);
                ActualizarDs();
                posicion = tblp.Rows.Count - 1;
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
            if (MessageBox.Show("Esta seguro de elimina a " + txtnombreproveedor.Text, "Registro de Proveedores",
              MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                String[] valores = { lblidproducto.Text };
                objConexion.Mantenimiento_proveedores(valores, "Eliminar");

                ActualizarDs();
                posicion = posicion > 0 ? posicion - 1 : 0;
                MostrarDatos();
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            Fbusquedaproveedores frmBusquedaproveedores = new Fbusquedaproveedores();
            frmBusquedaproveedores.ShowDialog();

            if (frmBusquedaproveedores._idproveedor > 0)
            {
                posicion = tblp.Rows.IndexOf(tblp.Rows.Find(frmBusquedaproveedores._idproveedor));
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
            posicion = tblp.Rows.Count - 1;
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
                MessageBox.Show("Primer Registro...", "Registros de Proveedor",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnsiguiente_Click(object sender, EventArgs e)
        {
            if (posicion < tblp.Rows.Count - 1)
            {
                posicion++;
                MostrarDatos();
            }
            else
            {
                MessageBox.Show("Ultimo Registro...", "Registros de Proveedor",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
