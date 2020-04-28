namespace Torres_Anibal_Parcial
{
    partial class Fempleados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbEdicion = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.grbNavegacion = new System.Windows.Forms.GroupBox();
            this.lblnregistros = new System.Windows.Forms.Label();
            this.btnultimo = new System.Windows.Forms.Button();
            this.btnsiguiente = new System.Windows.Forms.Button();
            this.btnanterior = new System.Windows.Forms.Button();
            this.btnprimero = new System.Windows.Forms.Button();
            this.grbDatosClientes = new System.Windows.Forms.GroupBox();
            this.txtsalario = new System.Windows.Forms.TextBox();
            this.lblsueldo = new System.Windows.Forms.Label();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.lblapellido = new System.Windows.Forms.Label();
            this.lblidempleado = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.lbl6 = new System.Windows.Forms.Label();
            this.txtdui = new System.Windows.Forms.TextBox();
            this.lbldui = new System.Windows.Forms.Label();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.lbltelefono = new System.Windows.Forms.Label();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.lbldireccion = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.lblnombre = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.grbEdicion.SuspendLayout();
            this.grbNavegacion.SuspendLayout();
            this.grbDatosClientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbEdicion
            // 
            this.grbEdicion.Controls.Add(this.btnBuscar);
            this.grbEdicion.Controls.Add(this.btneliminar);
            this.grbEdicion.Controls.Add(this.btnModificar);
            this.grbEdicion.Controls.Add(this.btnNuevo);
            this.grbEdicion.Location = new System.Drawing.Point(381, 10);
            this.grbEdicion.Margin = new System.Windows.Forms.Padding(1);
            this.grbEdicion.Name = "grbEdicion";
            this.grbEdicion.Padding = new System.Windows.Forms.Padding(1);
            this.grbEdicion.Size = new System.Drawing.Size(182, 330);
            this.grbEdicion.TabIndex = 17;
            this.grbEdicion.TabStop = false;
            this.grbEdicion.Text = "Edicion de Empleados";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnBuscar.Location = new System.Drawing.Point(43, 246);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(1);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(101, 37);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btneliminar.Location = new System.Drawing.Point(43, 177);
            this.btneliminar.Margin = new System.Windows.Forms.Padding(1);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(101, 34);
            this.btneliminar.TabIndex = 4;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = false;
            this.btneliminar.Click += new System.EventHandler(this.Btneliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.LightBlue;
            this.btnModificar.Location = new System.Drawing.Point(43, 108);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(1);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(101, 35);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnNuevo.Location = new System.Drawing.Point(43, 43);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(1);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(101, 39);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // grbNavegacion
            // 
            this.grbNavegacion.Controls.Add(this.lblnregistros);
            this.grbNavegacion.Controls.Add(this.btnultimo);
            this.grbNavegacion.Controls.Add(this.btnsiguiente);
            this.grbNavegacion.Controls.Add(this.btnanterior);
            this.grbNavegacion.Controls.Add(this.btnprimero);
            this.grbNavegacion.Location = new System.Drawing.Point(10, 342);
            this.grbNavegacion.Margin = new System.Windows.Forms.Padding(1);
            this.grbNavegacion.Name = "grbNavegacion";
            this.grbNavegacion.Padding = new System.Windows.Forms.Padding(1);
            this.grbNavegacion.Size = new System.Drawing.Size(417, 77);
            this.grbNavegacion.TabIndex = 16;
            this.grbNavegacion.TabStop = false;
            this.grbNavegacion.Text = "Navegacion";
            // 
            // lblnregistros
            // 
            this.lblnregistros.AutoSize = true;
            this.lblnregistros.Location = new System.Drawing.Point(89, 8);
            this.lblnregistros.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblnregistros.Name = "lblnregistros";
            this.lblnregistros.Size = new System.Drawing.Size(0, 13);
            this.lblnregistros.TabIndex = 13;
            // 
            // btnultimo
            // 
            this.btnultimo.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnultimo.Location = new System.Drawing.Point(277, 28);
            this.btnultimo.Margin = new System.Windows.Forms.Padding(1);
            this.btnultimo.Name = "btnultimo";
            this.btnultimo.Size = new System.Drawing.Size(105, 33);
            this.btnultimo.TabIndex = 3;
            this.btnultimo.Text = ">|";
            this.btnultimo.UseVisualStyleBackColor = false;
            this.btnultimo.Click += new System.EventHandler(this.btnultimo_Click);
            // 
            // btnsiguiente
            // 
            this.btnsiguiente.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnsiguiente.Location = new System.Drawing.Point(225, 28);
            this.btnsiguiente.Margin = new System.Windows.Forms.Padding(1);
            this.btnsiguiente.Name = "btnsiguiente";
            this.btnsiguiente.Size = new System.Drawing.Size(50, 33);
            this.btnsiguiente.TabIndex = 2;
            this.btnsiguiente.Text = ">";
            this.btnsiguiente.UseVisualStyleBackColor = false;
            this.btnsiguiente.Click += new System.EventHandler(this.btnsiguiente_Click);
            // 
            // btnanterior
            // 
            this.btnanterior.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnanterior.Location = new System.Drawing.Point(124, 28);
            this.btnanterior.Margin = new System.Windows.Forms.Padding(1);
            this.btnanterior.Name = "btnanterior";
            this.btnanterior.Size = new System.Drawing.Size(50, 33);
            this.btnanterior.TabIndex = 1;
            this.btnanterior.Text = "<";
            this.btnanterior.UseVisualStyleBackColor = false;
            this.btnanterior.Click += new System.EventHandler(this.btnanterior_Click);
            // 
            // btnprimero
            // 
            this.btnprimero.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnprimero.Location = new System.Drawing.Point(17, 28);
            this.btnprimero.Margin = new System.Windows.Forms.Padding(1);
            this.btnprimero.Name = "btnprimero";
            this.btnprimero.Size = new System.Drawing.Size(105, 33);
            this.btnprimero.TabIndex = 0;
            this.btnprimero.Text = "|<";
            this.btnprimero.UseVisualStyleBackColor = false;
            this.btnprimero.Click += new System.EventHandler(this.btnprimero_Click);
            // 
            // grbDatosClientes
            // 
            this.grbDatosClientes.Controls.Add(this.txtsalario);
            this.grbDatosClientes.Controls.Add(this.lblsueldo);
            this.grbDatosClientes.Controls.Add(this.txtapellido);
            this.grbDatosClientes.Controls.Add(this.lblapellido);
            this.grbDatosClientes.Controls.Add(this.lblidempleado);
            this.grbDatosClientes.Controls.Add(this.textBox6);
            this.grbDatosClientes.Controls.Add(this.lbl6);
            this.grbDatosClientes.Controls.Add(this.txtdui);
            this.grbDatosClientes.Controls.Add(this.lbldui);
            this.grbDatosClientes.Controls.Add(this.txttelefono);
            this.grbDatosClientes.Controls.Add(this.lbltelefono);
            this.grbDatosClientes.Controls.Add(this.txtdireccion);
            this.grbDatosClientes.Controls.Add(this.lbldireccion);
            this.grbDatosClientes.Controls.Add(this.txtnombre);
            this.grbDatosClientes.Controls.Add(this.lblnombre);
            this.grbDatosClientes.Controls.Add(this.txtcodigo);
            this.grbDatosClientes.Controls.Add(this.lblcodigo);
            this.grbDatosClientes.Enabled = false;
            this.grbDatosClientes.Location = new System.Drawing.Point(10, 10);
            this.grbDatosClientes.Margin = new System.Windows.Forms.Padding(1);
            this.grbDatosClientes.Name = "grbDatosClientes";
            this.grbDatosClientes.Padding = new System.Windows.Forms.Padding(1);
            this.grbDatosClientes.Size = new System.Drawing.Size(354, 330);
            this.grbDatosClientes.TabIndex = 15;
            this.grbDatosClientes.TabStop = false;
            this.grbDatosClientes.Text = "Datos de Empleados";
            // 
            // txtsalario
            // 
            this.txtsalario.Location = new System.Drawing.Point(82, 282);
            this.txtsalario.Margin = new System.Windows.Forms.Padding(1);
            this.txtsalario.Name = "txtsalario";
            this.txtsalario.Size = new System.Drawing.Size(81, 20);
            this.txtsalario.TabIndex = 16;
            // 
            // lblsueldo
            // 
            this.lblsueldo.AutoSize = true;
            this.lblsueldo.Location = new System.Drawing.Point(18, 282);
            this.lblsueldo.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblsueldo.Name = "lblsueldo";
            this.lblsueldo.Size = new System.Drawing.Size(54, 13);
            this.lblsueldo.TabIndex = 15;
            this.lblsueldo.Text = "SUELDO:";
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(82, 85);
            this.txtapellido.Margin = new System.Windows.Forms.Padding(1);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(205, 20);
            this.txtapellido.TabIndex = 14;
            // 
            // lblapellido
            // 
            this.lblapellido.AutoSize = true;
            this.lblapellido.Location = new System.Drawing.Point(15, 85);
            this.lblapellido.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblapellido.Name = "lblapellido";
            this.lblapellido.Size = new System.Drawing.Size(62, 13);
            this.lblapellido.TabIndex = 13;
            this.lblapellido.Text = "APELLIDO:";
            // 
            // lblidempleado
            // 
            this.lblidempleado.AutoSize = true;
            this.lblidempleado.Location = new System.Drawing.Point(199, 35);
            this.lblidempleado.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblidempleado.Name = "lblidempleado";
            this.lblidempleado.Size = new System.Drawing.Size(0, 13);
            this.lblidempleado.TabIndex = 12;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(154, 568);
            this.textBox6.Margin = new System.Windows.Forms.Padding(1);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(40, 20);
            this.textBox6.TabIndex = 9;
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.Location = new System.Drawing.Point(45, 568);
            this.lbl6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(0, 13);
            this.lbl6.TabIndex = 8;
            // 
            // txtdui
            // 
            this.txtdui.Location = new System.Drawing.Point(82, 208);
            this.txtdui.Margin = new System.Windows.Forms.Padding(1);
            this.txtdui.Name = "txtdui";
            this.txtdui.Size = new System.Drawing.Size(137, 20);
            this.txtdui.TabIndex = 7;
            // 
            // lbldui
            // 
            this.lbldui.AutoSize = true;
            this.lbldui.Location = new System.Drawing.Point(18, 210);
            this.lbldui.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbldui.Name = "lbldui";
            this.lbldui.Size = new System.Drawing.Size(29, 13);
            this.lbldui.TabIndex = 6;
            this.lbldui.Text = "DUI:";
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(82, 247);
            this.txttelefono.Margin = new System.Windows.Forms.Padding(1);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(81, 20);
            this.txttelefono.TabIndex = 5;
            // 
            // lbltelefono
            // 
            this.lbltelefono.AutoSize = true;
            this.lbltelefono.Location = new System.Drawing.Point(18, 247);
            this.lbltelefono.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbltelefono.Name = "lbltelefono";
            this.lbltelefono.Size = new System.Drawing.Size(30, 13);
            this.lbltelefono.TabIndex = 4;
            this.lbltelefono.Text = "TEL:";
            // 
            // txtdireccion
            // 
            this.txtdireccion.Location = new System.Drawing.Point(82, 120);
            this.txtdireccion.Margin = new System.Windows.Forms.Padding(1);
            this.txtdireccion.Multiline = true;
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(194, 50);
            this.txtdireccion.TabIndex = 3;
            // 
            // lbldireccion
            // 
            this.lbldireccion.AutoSize = true;
            this.lbldireccion.Location = new System.Drawing.Point(11, 120);
            this.lbldireccion.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbldireccion.Name = "lbldireccion";
            this.lbldireccion.Size = new System.Drawing.Size(69, 13);
            this.lbldireccion.TabIndex = 2;
            this.lbldireccion.Text = "DIRECCION:";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(82, 63);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(1);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(205, 20);
            this.txtnombre.TabIndex = 3;
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(15, 63);
            this.lblnombre.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(57, 13);
            this.lblnombre.TabIndex = 2;
            this.lblnombre.Text = "NOMBRE:";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(82, 35);
            this.txtcodigo.Margin = new System.Windows.Forms.Padding(1);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(76, 20);
            this.txtcodigo.TabIndex = 1;
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Location = new System.Drawing.Point(15, 35);
            this.lblcodigo.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(52, 13);
            this.lblcodigo.TabIndex = 0;
            this.lblcodigo.Text = "CODIGO:";
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Red;
            this.btnVolver.Location = new System.Drawing.Point(462, 370);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(89, 23);
            this.btnVolver.TabIndex = 18;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click_1);
            // 
            // Fempleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.ClientSize = new System.Drawing.Size(579, 429);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.grbEdicion);
            this.Controls.Add(this.grbNavegacion);
            this.Controls.Add(this.grbDatosClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Fempleados";
            this.Text = "Fempleados";
            this.grbEdicion.ResumeLayout(false);
            this.grbNavegacion.ResumeLayout(false);
            this.grbNavegacion.PerformLayout();
            this.grbDatosClientes.ResumeLayout(false);
            this.grbDatosClientes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbEdicion;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.GroupBox grbNavegacion;
        private System.Windows.Forms.Label lblnregistros;
        private System.Windows.Forms.Button btnultimo;
        private System.Windows.Forms.Button btnsiguiente;
        private System.Windows.Forms.Button btnanterior;
        private System.Windows.Forms.Button btnprimero;
        private System.Windows.Forms.GroupBox grbDatosClientes;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.Label lblapellido;
        private System.Windows.Forms.Label lblidempleado;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.TextBox txtdui;
        private System.Windows.Forms.Label lbldui;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.Label lbltelefono;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.Label lbldireccion;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.TextBox txtsalario;
        private System.Windows.Forms.Label lblsueldo;
        private System.Windows.Forms.Button btnVolver;
    }
}