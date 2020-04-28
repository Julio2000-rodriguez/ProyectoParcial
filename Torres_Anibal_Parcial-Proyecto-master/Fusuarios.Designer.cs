namespace Torres_Anibal_Parcial
{
    partial class Fusuarios
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
            this.grbClientes = new System.Windows.Forms.GroupBox();
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
            this.grbDatosUsuarios = new System.Windows.Forms.GroupBox();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.lblapellido = new System.Windows.Forms.Label();
            this.lblidusuario = new System.Windows.Forms.Label();
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
            this.grbClientes.SuspendLayout();
            this.grbNavegacion.SuspendLayout();
            this.grbDatosUsuarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbClientes
            // 
            this.grbClientes.Controls.Add(this.btnBuscar);
            this.grbClientes.Controls.Add(this.btneliminar);
            this.grbClientes.Controls.Add(this.btnModificar);
            this.grbClientes.Controls.Add(this.btnNuevo);
            this.grbClientes.Font = new System.Drawing.Font("Ubuntu", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbClientes.Location = new System.Drawing.Point(394, 30);
            this.grbClientes.Margin = new System.Windows.Forms.Padding(1);
            this.grbClientes.Name = "grbClientes";
            this.grbClientes.Padding = new System.Windows.Forms.Padding(1);
            this.grbClientes.Size = new System.Drawing.Size(182, 330);
            this.grbClientes.TabIndex = 13;
            this.grbClientes.TabStop = false;
            this.grbClientes.Text = "Edicion de Usuarios";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.DarkSeaGreen;
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
            this.btneliminar.BackColor = System.Drawing.Color.Orange;
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
            this.grbNavegacion.Font = new System.Drawing.Font("Ubuntu", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbNavegacion.Location = new System.Drawing.Point(23, 362);
            this.grbNavegacion.Margin = new System.Windows.Forms.Padding(1);
            this.grbNavegacion.Name = "grbNavegacion";
            this.grbNavegacion.Padding = new System.Windows.Forms.Padding(1);
            this.grbNavegacion.Size = new System.Drawing.Size(354, 68);
            this.grbNavegacion.TabIndex = 12;
            this.grbNavegacion.TabStop = false;
            this.grbNavegacion.Text = "Navegacion";
            // 
            // lblnregistros
            // 
            this.lblnregistros.AutoSize = true;
            this.lblnregistros.Location = new System.Drawing.Point(95, 6);
            this.lblnregistros.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblnregistros.Name = "lblnregistros";
            this.lblnregistros.Size = new System.Drawing.Size(0, 16);
            this.lblnregistros.TabIndex = 13;
            // 
            // btnultimo
            // 
            this.btnultimo.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnultimo.Location = new System.Drawing.Point(246, 26);
            this.btnultimo.Margin = new System.Windows.Forms.Padding(1);
            this.btnultimo.Name = "btnultimo";
            this.btnultimo.Size = new System.Drawing.Size(84, 33);
            this.btnultimo.TabIndex = 3;
            this.btnultimo.Text = ">|";
            this.btnultimo.UseVisualStyleBackColor = false;
            this.btnultimo.Click += new System.EventHandler(this.btnultimo_Click);
            // 
            // btnsiguiente
            // 
            this.btnsiguiente.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnsiguiente.Location = new System.Drawing.Point(185, 26);
            this.btnsiguiente.Margin = new System.Windows.Forms.Padding(1);
            this.btnsiguiente.Name = "btnsiguiente";
            this.btnsiguiente.Size = new System.Drawing.Size(34, 33);
            this.btnsiguiente.TabIndex = 2;
            this.btnsiguiente.Text = ">";
            this.btnsiguiente.UseVisualStyleBackColor = false;
            this.btnsiguiente.Click += new System.EventHandler(this.btnsiguiente_Click);
            // 
            // btnanterior
            // 
            this.btnanterior.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnanterior.Location = new System.Drawing.Point(113, 26);
            this.btnanterior.Margin = new System.Windows.Forms.Padding(1);
            this.btnanterior.Name = "btnanterior";
            this.btnanterior.Size = new System.Drawing.Size(33, 33);
            this.btnanterior.TabIndex = 1;
            this.btnanterior.Text = "<";
            this.btnanterior.UseVisualStyleBackColor = false;
            this.btnanterior.Click += new System.EventHandler(this.btnanterior_Click);
            // 
            // btnprimero
            // 
            this.btnprimero.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnprimero.Location = new System.Drawing.Point(14, 26);
            this.btnprimero.Margin = new System.Windows.Forms.Padding(1);
            this.btnprimero.Name = "btnprimero";
            this.btnprimero.Size = new System.Drawing.Size(84, 33);
            this.btnprimero.TabIndex = 0;
            this.btnprimero.Text = "|<";
            this.btnprimero.UseVisualStyleBackColor = false;
            this.btnprimero.Click += new System.EventHandler(this.btnprimero_Click);
            // 
            // grbDatosUsuarios
            // 
            this.grbDatosUsuarios.Controls.Add(this.txtapellido);
            this.grbDatosUsuarios.Controls.Add(this.lblapellido);
            this.grbDatosUsuarios.Controls.Add(this.lblidusuario);
            this.grbDatosUsuarios.Controls.Add(this.textBox6);
            this.grbDatosUsuarios.Controls.Add(this.lbl6);
            this.grbDatosUsuarios.Controls.Add(this.txtdui);
            this.grbDatosUsuarios.Controls.Add(this.lbldui);
            this.grbDatosUsuarios.Controls.Add(this.txttelefono);
            this.grbDatosUsuarios.Controls.Add(this.lbltelefono);
            this.grbDatosUsuarios.Controls.Add(this.txtdireccion);
            this.grbDatosUsuarios.Controls.Add(this.lbldireccion);
            this.grbDatosUsuarios.Controls.Add(this.txtnombre);
            this.grbDatosUsuarios.Controls.Add(this.lblnombre);
            this.grbDatosUsuarios.Controls.Add(this.txtcodigo);
            this.grbDatosUsuarios.Controls.Add(this.lblcodigo);
            this.grbDatosUsuarios.Enabled = false;
            this.grbDatosUsuarios.Font = new System.Drawing.Font("Ubuntu", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDatosUsuarios.Location = new System.Drawing.Point(23, 30);
            this.grbDatosUsuarios.Margin = new System.Windows.Forms.Padding(1);
            this.grbDatosUsuarios.Name = "grbDatosUsuarios";
            this.grbDatosUsuarios.Padding = new System.Windows.Forms.Padding(1);
            this.grbDatosUsuarios.Size = new System.Drawing.Size(354, 330);
            this.grbDatosUsuarios.TabIndex = 11;
            this.grbDatosUsuarios.TabStop = false;
            this.grbDatosUsuarios.Text = "Datos de Usuarios";
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(82, 85);
            this.txtapellido.Margin = new System.Windows.Forms.Padding(1);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(205, 21);
            this.txtapellido.TabIndex = 14;
            // 
            // lblapellido
            // 
            this.lblapellido.AutoSize = true;
            this.lblapellido.Location = new System.Drawing.Point(15, 85);
            this.lblapellido.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblapellido.Name = "lblapellido";
            this.lblapellido.Size = new System.Drawing.Size(65, 16);
            this.lblapellido.TabIndex = 13;
            this.lblapellido.Text = "APELLIDO:";
            // 
            // lblidusuario
            // 
            this.lblidusuario.AutoSize = true;
            this.lblidusuario.Location = new System.Drawing.Point(199, 35);
            this.lblidusuario.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblidusuario.Name = "lblidusuario";
            this.lblidusuario.Size = new System.Drawing.Size(0, 16);
            this.lblidusuario.TabIndex = 12;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(154, 568);
            this.textBox6.Margin = new System.Windows.Forms.Padding(1);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(40, 21);
            this.textBox6.TabIndex = 9;
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.Location = new System.Drawing.Point(45, 568);
            this.lbl6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(0, 16);
            this.lbl6.TabIndex = 8;
            // 
            // txtdui
            // 
            this.txtdui.Location = new System.Drawing.Point(82, 208);
            this.txtdui.Margin = new System.Windows.Forms.Padding(1);
            this.txtdui.Name = "txtdui";
            this.txtdui.Size = new System.Drawing.Size(137, 21);
            this.txtdui.TabIndex = 7;
            // 
            // lbldui
            // 
            this.lbldui.AutoSize = true;
            this.lbldui.Location = new System.Drawing.Point(18, 210);
            this.lbldui.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbldui.Name = "lbldui";
            this.lbldui.Size = new System.Drawing.Size(31, 16);
            this.lbldui.TabIndex = 6;
            this.lbldui.Text = "DUI:";
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(82, 247);
            this.txttelefono.Margin = new System.Windows.Forms.Padding(1);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(81, 21);
            this.txttelefono.TabIndex = 5;
            // 
            // lbltelefono
            // 
            this.lbltelefono.AutoSize = true;
            this.lbltelefono.Location = new System.Drawing.Point(18, 247);
            this.lbltelefono.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbltelefono.Name = "lbltelefono";
            this.lbltelefono.Size = new System.Drawing.Size(31, 16);
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
            this.lbldireccion.Size = new System.Drawing.Size(75, 16);
            this.lbldireccion.TabIndex = 2;
            this.lbldireccion.Text = "DIRECCION:";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(82, 63);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(1);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(205, 21);
            this.txtnombre.TabIndex = 3;
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(15, 63);
            this.lblnombre.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(63, 16);
            this.lblnombre.TabIndex = 2;
            this.lblnombre.Text = "NOMBRE:";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(82, 35);
            this.txtcodigo.Margin = new System.Windows.Forms.Padding(1);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(76, 21);
            this.txtcodigo.TabIndex = 1;
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Location = new System.Drawing.Point(15, 35);
            this.lblcodigo.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(57, 16);
            this.lblcodigo.TabIndex = 0;
            this.lblcodigo.Text = "CODIGO:";
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Red;
            this.btnVolver.Font = new System.Drawing.Font("Ubuntu", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(486, 398);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(77, 32);
            this.btnVolver.TabIndex = 10;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // Fusuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.ClientSize = new System.Drawing.Size(595, 452);
            this.Controls.Add(this.grbClientes);
            this.Controls.Add(this.grbNavegacion);
            this.Controls.Add(this.grbDatosUsuarios);
            this.Controls.Add(this.btnVolver);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Fusuarios";
            this.Text = "Fusuarios";
            this.grbClientes.ResumeLayout(false);
            this.grbNavegacion.ResumeLayout(false);
            this.grbNavegacion.PerformLayout();
            this.grbDatosUsuarios.ResumeLayout(false);
            this.grbDatosUsuarios.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbClientes;
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
        private System.Windows.Forms.GroupBox grbDatosUsuarios;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.Label lblapellido;
        private System.Windows.Forms.Label lblidusuario;
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
        private System.Windows.Forms.Button btnVolver;
    }
}