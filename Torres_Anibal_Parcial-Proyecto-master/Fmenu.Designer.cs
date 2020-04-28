namespace Torres_Anibal_Parcial
{
    partial class Fmenu
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
            this.btnMateriales = new System.Windows.Forms.Button();
            this.btnPanes = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.Btnsalir = new System.Windows.Forms.Button();
            this.btnEmpleado = new System.Windows.Forms.Button();
            this.btnVenta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMateriales
            // 
            this.btnMateriales.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnMateriales.Font = new System.Drawing.Font("Ubuntu", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMateriales.Location = new System.Drawing.Point(481, 50);
            this.btnMateriales.Name = "btnMateriales";
            this.btnMateriales.Size = new System.Drawing.Size(145, 67);
            this.btnMateriales.TabIndex = 11;
            this.btnMateriales.Text = "Proveedores";
            this.btnMateriales.UseVisualStyleBackColor = false;
            this.btnMateriales.Click += new System.EventHandler(this.btnMateriales_Click);
            // 
            // btnPanes
            // 
            this.btnPanes.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnPanes.Font = new System.Drawing.Font("Ubuntu", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPanes.Location = new System.Drawing.Point(481, 203);
            this.btnPanes.Name = "btnPanes";
            this.btnPanes.Size = new System.Drawing.Size(145, 67);
            this.btnPanes.TabIndex = 10;
            this.btnPanes.Text = "Productos";
            this.btnPanes.UseVisualStyleBackColor = false;
            this.btnPanes.Click += new System.EventHandler(this.BtnProducto_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnCliente.Font = new System.Drawing.Font("Ubuntu", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.Location = new System.Drawing.Point(71, 50);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(145, 67);
            this.btnCliente.TabIndex = 9;
            this.btnCliente.Text = "Clientes";
            this.btnCliente.UseVisualStyleBackColor = false;
            this.btnCliente.Click += new System.EventHandler(this.BtnCliente_Click);
            // 
            // Btnsalir
            // 
            this.Btnsalir.BackColor = System.Drawing.Color.Red;
            this.Btnsalir.Font = new System.Drawing.Font("Ubuntu", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnsalir.Location = new System.Drawing.Point(12, 408);
            this.Btnsalir.Name = "Btnsalir";
            this.Btnsalir.Size = new System.Drawing.Size(91, 33);
            this.Btnsalir.TabIndex = 8;
            this.Btnsalir.Text = "Salir";
            this.Btnsalir.UseVisualStyleBackColor = false;
            this.Btnsalir.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnEmpleado
            // 
            this.btnEmpleado.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnEmpleado.Font = new System.Drawing.Font("Ubuntu", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleado.Location = new System.Drawing.Point(71, 203);
            this.btnEmpleado.Name = "btnEmpleado";
            this.btnEmpleado.Size = new System.Drawing.Size(145, 67);
            this.btnEmpleado.TabIndex = 12;
            this.btnEmpleado.Text = "Empleados";
            this.btnEmpleado.UseVisualStyleBackColor = false;
            this.btnEmpleado.Click += new System.EventHandler(this.BtnEmpleado_Click);
            // 
            // btnVenta
            // 
            this.btnVenta.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnVenta.Font = new System.Drawing.Font("Ubuntu", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVenta.Location = new System.Drawing.Point(279, 340);
            this.btnVenta.Name = "btnVenta";
            this.btnVenta.Size = new System.Drawing.Size(145, 67);
            this.btnVenta.TabIndex = 13;
            this.btnVenta.UseVisualStyleBackColor = false;
            this.btnVenta.Click += new System.EventHandler(this.BtnVenta_Click);
            // 
            // Fmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.ClientSize = new System.Drawing.Size(718, 453);
            this.Controls.Add(this.btnVenta);
            this.Controls.Add(this.btnEmpleado);
            this.Controls.Add(this.btnMateriales);
            this.Controls.Add(this.btnPanes);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.Btnsalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Fmenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMateriales;
        private System.Windows.Forms.Button btnPanes;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button Btnsalir;
        private System.Windows.Forms.Button btnEmpleado;
        private System.Windows.Forms.Button btnVenta;
    }
}