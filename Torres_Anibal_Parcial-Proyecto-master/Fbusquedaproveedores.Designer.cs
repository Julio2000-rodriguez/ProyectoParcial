namespace Torres_Anibal_Parcial
{
    partial class Fbusquedaproveedores
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
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnseleccionar = new System.Windows.Forms.Button();
            this.grdBusquedaproveedores = new System.Windows.Forms.DataGridView();
            this.idcliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_contacto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.lblbuscar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdBusquedaproveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.Color.Chartreuse;
            this.btncancelar.Location = new System.Drawing.Point(613, 17);
            this.btncancelar.Margin = new System.Windows.Forms.Padding(1);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(119, 31);
            this.btncancelar.TabIndex = 32;
            this.btncancelar.Text = "CANCELAR";
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.Btncancelar_Click);
            // 
            // btnseleccionar
            // 
            this.btnseleccionar.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnseleccionar.Location = new System.Drawing.Point(467, 17);
            this.btnseleccionar.Margin = new System.Windows.Forms.Padding(1);
            this.btnseleccionar.Name = "btnseleccionar";
            this.btnseleccionar.Size = new System.Drawing.Size(125, 31);
            this.btnseleccionar.TabIndex = 31;
            this.btnseleccionar.Text = "SELECCIONAR";
            this.btnseleccionar.UseVisualStyleBackColor = false;
            this.btnseleccionar.Click += new System.EventHandler(this.Btnseleccionar_Click);
            // 
            // grdBusquedaproveedores
            // 
            this.grdBusquedaproveedores.AllowUserToAddRows = false;
            this.grdBusquedaproveedores.AllowUserToDeleteRows = false;
            this.grdBusquedaproveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBusquedaproveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcliente,
            this.codigo,
            this.nombre_proveedor,
            this.nombre_contacto,
            this.cargo,
            this.direccion,
            this.telefono,
            this.email});
            this.grdBusquedaproveedores.Location = new System.Drawing.Point(8, 64);
            this.grdBusquedaproveedores.Margin = new System.Windows.Forms.Padding(1);
            this.grdBusquedaproveedores.Name = "grdBusquedaproveedores";
            this.grdBusquedaproveedores.ReadOnly = true;
            this.grdBusquedaproveedores.RowHeadersWidth = 102;
            this.grdBusquedaproveedores.RowTemplate.Height = 40;
            this.grdBusquedaproveedores.Size = new System.Drawing.Size(774, 354);
            this.grdBusquedaproveedores.TabIndex = 30;
            this.grdBusquedaproveedores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdBusquedaproveedores_CellContentClick);
            // 
            // idcliente
            // 
            this.idcliente.DataPropertyName = "idproveedor";
            this.idcliente.HeaderText = "ID";
            this.idcliente.MinimumWidth = 12;
            this.idcliente.Name = "idcliente";
            this.idcliente.ReadOnly = true;
            this.idcliente.Visible = false;
            this.idcliente.Width = 70;
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "codigo";
            this.codigo.HeaderText = "CODIGO";
            this.codigo.MinimumWidth = 12;
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 70;
            // 
            // nombre_proveedor
            // 
            this.nombre_proveedor.DataPropertyName = "nombrep";
            this.nombre_proveedor.HeaderText = "NOMBRE_PROVEEDOR";
            this.nombre_proveedor.MinimumWidth = 12;
            this.nombre_proveedor.Name = "nombre_proveedor";
            this.nombre_proveedor.ReadOnly = true;
            this.nombre_proveedor.Width = 130;
            // 
            // nombre_contacto
            // 
            this.nombre_contacto.DataPropertyName = "nombrec";
            this.nombre_contacto.HeaderText = "NOMBRE_CONTACTO";
            this.nombre_contacto.Name = "nombre_contacto";
            this.nombre_contacto.ReadOnly = true;
            this.nombre_contacto.Width = 125;
            // 
            // cargo
            // 
            this.cargo.DataPropertyName = "cargoc";
            this.cargo.HeaderText = "CARGO_CONTACTO";
            this.cargo.Name = "cargo";
            this.cargo.ReadOnly = true;
            this.cargo.Width = 125;
            // 
            // direccion
            // 
            this.direccion.DataPropertyName = "direccion";
            this.direccion.HeaderText = "DIRECCION";
            this.direccion.MinimumWidth = 12;
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            this.direccion.Width = 70;
            // 
            // telefono
            // 
            this.telefono.DataPropertyName = "telefono";
            this.telefono.HeaderText = "TELEFONO";
            this.telefono.MinimumWidth = 12;
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            this.telefono.Width = 70;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "EMAIL";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(79, 23);
            this.txtbuscar.Margin = new System.Windows.Forms.Padding(1);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(341, 20);
            this.txtbuscar.TabIndex = 29;
            this.txtbuscar.TextChanged += new System.EventHandler(this.Txtbuscar_TextChanged);
            // 
            // lblbuscar
            // 
            this.lblbuscar.AutoSize = true;
            this.lblbuscar.Location = new System.Drawing.Point(12, 26);
            this.lblbuscar.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblbuscar.Name = "lblbuscar";
            this.lblbuscar.Size = new System.Drawing.Size(54, 13);
            this.lblbuscar.TabIndex = 28;
            this.lblbuscar.Text = "BUSCAR:";
            // 
            // Fbusquedaproveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.ClientSize = new System.Drawing.Size(792, 430);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnseleccionar);
            this.Controls.Add(this.grdBusquedaproveedores);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.lblbuscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Fbusquedaproveedores";
            this.Text = "Fbusquedaproveedores";
            this.Load += new System.EventHandler(this.Fbusquedaproveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdBusquedaproveedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnseleccionar;
        private System.Windows.Forms.DataGridView grdBusquedaproveedores;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Label lblbuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_contacto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
    }
}