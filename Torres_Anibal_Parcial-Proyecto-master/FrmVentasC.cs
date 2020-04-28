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
    public partial class FrmVentasC : Form
    {
        ConexionDB objConexion = new ConexionDB();
        int posicion = 0;
        string accion = "Nuevo";
        DataTable tbl = new DataTable();


        public FrmVentasC()
        {
            InitializeComponent();
            
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
                    lblidVentas.Text,
                    txtcodigo.Text,
                    txtnombre.Text,
                    txtdescripcion.Text,
                    txtprecio.Text,
                    txtnombrec.Text,
                    txttelefono.Text,
                    
                };

                objConexion.mantenimiento_ventas(valores, accion);
                ActualizarDs();
                posicion = tbl.Rows.Count - 1;
                MostrarDatos();

                Controles(true);

                btnNuevo.Text = "Nuevo";
                btnModificar.Text = "Modificar";
            }

        }

        private void btnprimero_Click(object sender, EventArgs e)
        {
            posicion = 0;
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
                MessageBox.Show("Primer Registro...", "Registros de ventas",
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
                MessageBox.Show("Ultimo Registro...", "Registros de ventas",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnultimo_Click(object sender, EventArgs e)
        {

            posicion = tbl.Rows.Count - 1;
            MostrarDatos();

        }

        private void btnModificar_Click(object sender, EventArgs e)
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

        private void btneliminar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Esta seguro de elimina a " + txtnombre.Text, "Registro de ventas",
               MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                String[] valores = { lblidVentas.Text };
                objConexion.mantenimiento_ventas(valores, "Eliminar");

                ActualizarDs();
                posicion = posicion > 0 ? posicion - 1 : 0;
                MostrarDatos();
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            FrmBusquedaVentas FrmBVentas = new FrmBusquedaVentas();
            FrmBVentas.ShowDialog();

            if (FrmBVentas.IdVentas > 0)
            {
                posicion = tbl.Rows.IndexOf(tbl.Rows.Find(FrmBVentas.IdVentas));
                MostrarDatos();
            }

        }

        void Limpiar_cajas()
        {
            txtcodigo.Text = "";
            txtnombre.Text = "";
            txtdescripcion.Text = "";
            txtprecio.Text = "";
            txtnombrec.Text = "";
            txttelefono.Text = "";

        }
        void Controles(Boolean valor)
        {
            grbNavegacion.Enabled = valor;
            btneliminar.Enabled = valor;
            btnBuscar.Enabled = valor;
            grbDatosClientes.Enabled = !valor;
        }

        void ActualizarDs()
        {
            tbl = objConexion.Obtener_datos().Tables["Ventas"];
            tbl.PrimaryKey = new DataColumn[] { tbl.Columns["IdVentas"] };
            MostrarDatos();
        }
        void MostrarDatos()
        {
            try
            {
                lblidVentas.Text = tbl.Rows[posicion].ItemArray[0].ToString();
                txtcodigo.Text = tbl.Rows[posicion].ItemArray[1].ToString();
                txtnombre.Text = tbl.Rows[posicion].ItemArray[2].ToString();
                txtdescripcion.Text = tbl.Rows[posicion].ItemArray[3].ToString();
                txtprecio.Text = tbl.Rows[posicion].ItemArray[4].ToString();
                txtnombrec.Text = tbl.Rows[posicion].ItemArray[5].ToString();
                txttelefono.Text = tbl.Rows[posicion].ItemArray[6].ToString();


                lblnregistros.Text = (posicion + 1) + " de " + tbl.Rows.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No hay Datos que mostrar", "Registros de una ventas",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar_cajas();
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
