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
    public partial class Fempleados : Form
    {
        ConexionDB objConexion = new ConexionDB();
        int posicion = 0;

        string accion = "Nuevo";
        DataTable tbl = new DataTable();
        public Fempleados()
        {
            InitializeComponent();
        }
        void ActualizarDs()
        {
            tbl = objConexion.Obtener_datos().Tables["empleados"];
            tbl.PrimaryKey = new DataColumn[] { tbl.Columns["idempleado"] };
            MostrarDatos();
        }
        void MostrarDatos()
        {
            try
            {
                lblidempleado.Text = tbl.Rows[posicion].ItemArray[0].ToString();
                txtcodigo.Text = tbl.Rows[posicion].ItemArray[1].ToString();
                txtnombre.Text = tbl.Rows[posicion].ItemArray[2].ToString();
                txtapellido.Text = tbl.Rows[posicion].ItemArray[3].ToString();
                txtdireccion.Text = tbl.Rows[posicion].ItemArray[4].ToString();
                txtdui.Text = tbl.Rows[posicion].ItemArray[5].ToString();
                txttelefono.Text = tbl.Rows[posicion].ItemArray[6].ToString();
                txtsalario.Text = tbl.Rows[posicion].ItemArray[7].ToString();

                lblnregistros.Text = (posicion + 1) + " de " + tbl.Rows.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No hay Datos que mostrar", "Registros de Empleados",
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
            txtsalario.Text = "";
        }
        void Controles(Boolean valor)
        {
            grbNavegacion.Enabled = valor;
            btneliminar.Enabled = valor;
            btnBuscar.Enabled = valor;
            grbDatosClientes.Enabled = !valor;
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
                    lblidempleado.Text,
                    txtcodigo.Text,
                    txtnombre.Text,
                    txtapellido.Text,
                    txtdireccion.Text,
                    txtdui.Text,
                    txttelefono.Text,
                    txtsalario.Text,
                };

                objConexion.Mantenimiento_empleados(valores, accion);
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
            if (MessageBox.Show("Esta seguro de elimina a " + txtnombre.Text, "Registro de Empleados",
               MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                String[] valores = { lblidempleado.Text };
                objConexion.Mantenimiento_empleados(valores, "Eliminar");

                ActualizarDs();
                posicion = posicion > 0 ? posicion - 1 : 0;
                MostrarDatos();
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            Fbusquedaempleados frmBusquedaempleados = new Fbusquedaempleados();
            frmBusquedaempleados.ShowDialog();

            if (frmBusquedaempleados._idempleado > 0)
            {
                posicion = tbl.Rows.IndexOf(tbl.Rows.Find(frmBusquedaempleados._idempleado));
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

        private void btnanterior_Click(object sender, EventArgs e)
        {
            if (posicion > 0)
            {
                posicion--;
                MostrarDatos();
            }
            else
            {
                MessageBox.Show("Primer Registro...", "Registros de Empleado",
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
                MessageBox.Show("Ultimo Registro...", "Registros de Empleado",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnultimo_Click(object sender, EventArgs e)
        {
            posicion = tbl.Rows.Count - 1;
            MostrarDatos();
        }

        private void btnVolver_Click_1(object sender, EventArgs e)
        {
            Fmenu cambio = new Fmenu();
            this.Hide();
            cambio.ShowDialog();
            this.Close();
        }
    }
}
