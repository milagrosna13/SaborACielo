namespace SaborAcielo
{
    partial class MDIempleado
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.PmenuEmpleado = new System.Windows.Forms.Panel();
            this.PsubmnVentas = new System.Windows.Forms.Panel();
            this.BlistarVenta = new System.Windows.Forms.Button();
            this.BnuevaVenta = new System.Windows.Forms.Button();
            this.Bventa = new System.Windows.Forms.Button();
            this.PsubmnProductos = new System.Windows.Forms.Panel();
            this.BmostrarProdu = new System.Windows.Forms.Button();
            this.Bproducto = new System.Windows.Forms.Button();
            this.PsubmnClientes = new System.Windows.Forms.Panel();
            this.BverC = new System.Windows.Forms.Button();
            this.BagregarC = new System.Windows.Forms.Button();
            this.Bcliente = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BcerrarSesion = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PchildForm = new System.Windows.Forms.Panel();
            this.PmenuEmpleado.SuspendLayout();
            this.PsubmnVentas.SuspendLayout();
            this.PsubmnProductos.SuspendLayout();
            this.PsubmnClientes.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PmenuEmpleado
            // 
            this.PmenuEmpleado.AutoScroll = true;
            this.PmenuEmpleado.BackColor = System.Drawing.Color.SaddleBrown;
            this.PmenuEmpleado.Controls.Add(this.PsubmnVentas);
            this.PmenuEmpleado.Controls.Add(this.Bventa);
            this.PmenuEmpleado.Controls.Add(this.PsubmnProductos);
            this.PmenuEmpleado.Controls.Add(this.Bproducto);
            this.PmenuEmpleado.Controls.Add(this.PsubmnClientes);
            this.PmenuEmpleado.Controls.Add(this.Bcliente);
            this.PmenuEmpleado.Controls.Add(this.panel2);
            this.PmenuEmpleado.Dock = System.Windows.Forms.DockStyle.Left;
            this.PmenuEmpleado.Location = new System.Drawing.Point(0, 0);
            this.PmenuEmpleado.Name = "PmenuEmpleado";
            this.PmenuEmpleado.Size = new System.Drawing.Size(365, 892);
            this.PmenuEmpleado.TabIndex = 4;
            // 
            // PsubmnVentas
            // 
            this.PsubmnVentas.BackColor = System.Drawing.Color.Sienna;
            this.PsubmnVentas.Controls.Add(this.BlistarVenta);
            this.PsubmnVentas.Controls.Add(this.BnuevaVenta);
            this.PsubmnVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.PsubmnVentas.Font = new System.Drawing.Font("Script MT Bold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PsubmnVentas.ForeColor = System.Drawing.Color.Transparent;
            this.PsubmnVentas.Location = new System.Drawing.Point(0, 721);
            this.PsubmnVentas.Name = "PsubmnVentas";
            this.PsubmnVentas.Size = new System.Drawing.Size(365, 116);
            this.PsubmnVentas.TabIndex = 6;
            this.PsubmnVentas.Visible = false;
            // 
            // BlistarVenta
            // 
            this.BlistarVenta.BackColor = System.Drawing.Color.Transparent;
            this.BlistarVenta.Dock = System.Windows.Forms.DockStyle.Top;
            this.BlistarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BlistarVenta.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlistarVenta.ForeColor = System.Drawing.Color.Black;
            this.BlistarVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BlistarVenta.Location = new System.Drawing.Point(0, 52);
            this.BlistarVenta.Name = "BlistarVenta";
            this.BlistarVenta.Size = new System.Drawing.Size(365, 52);
            this.BlistarVenta.TabIndex = 3;
            this.BlistarVenta.Text = "Listar";
            this.BlistarVenta.UseVisualStyleBackColor = false;
            this.BlistarVenta.Click += new System.EventHandler(this.BlistarVenta_Click);
            // 
            // BnuevaVenta
            // 
            this.BnuevaVenta.BackColor = System.Drawing.Color.Transparent;
            this.BnuevaVenta.Dock = System.Windows.Forms.DockStyle.Top;
            this.BnuevaVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BnuevaVenta.ForeColor = System.Drawing.Color.Black;
            this.BnuevaVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BnuevaVenta.Location = new System.Drawing.Point(0, 0);
            this.BnuevaVenta.Name = "BnuevaVenta";
            this.BnuevaVenta.Size = new System.Drawing.Size(365, 52);
            this.BnuevaVenta.TabIndex = 2;
            this.BnuevaVenta.Text = "Generar ventas";
            this.BnuevaVenta.UseVisualStyleBackColor = false;
            this.BnuevaVenta.Click += new System.EventHandler(this.BnuevaVenta_Click);
            // 
            // Bventa
            // 
            this.Bventa.BackColor = System.Drawing.Color.SaddleBrown;
            this.Bventa.Dock = System.Windows.Forms.DockStyle.Top;
            this.Bventa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bventa.Font = new System.Drawing.Font("Script MT Bold", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bventa.ForeColor = System.Drawing.Color.RosyBrown;
            this.Bventa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Bventa.Location = new System.Drawing.Point(0, 669);
            this.Bventa.Name = "Bventa";
            this.Bventa.Size = new System.Drawing.Size(365, 52);
            this.Bventa.TabIndex = 5;
            this.Bventa.Text = "Ventas";
            this.Bventa.UseVisualStyleBackColor = false;
            this.Bventa.Click += new System.EventHandler(this.Bventa_Click);
            // 
            // PsubmnProductos
            // 
            this.PsubmnProductos.BackColor = System.Drawing.Color.Sienna;
            this.PsubmnProductos.Controls.Add(this.BmostrarProdu);
            this.PsubmnProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.PsubmnProductos.Font = new System.Drawing.Font("Script MT Bold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PsubmnProductos.ForeColor = System.Drawing.Color.LightCoral;
            this.PsubmnProductos.Location = new System.Drawing.Point(0, 608);
            this.PsubmnProductos.Name = "PsubmnProductos";
            this.PsubmnProductos.Size = new System.Drawing.Size(365, 61);
            this.PsubmnProductos.TabIndex = 4;
            this.PsubmnProductos.Visible = false;
            // 
            // BmostrarProdu
            // 
            this.BmostrarProdu.BackColor = System.Drawing.Color.Transparent;
            this.BmostrarProdu.Dock = System.Windows.Forms.DockStyle.Top;
            this.BmostrarProdu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BmostrarProdu.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BmostrarProdu.ForeColor = System.Drawing.Color.Black;
            this.BmostrarProdu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BmostrarProdu.Location = new System.Drawing.Point(0, 0);
            this.BmostrarProdu.Name = "BmostrarProdu";
            this.BmostrarProdu.Size = new System.Drawing.Size(365, 52);
            this.BmostrarProdu.TabIndex = 2;
            this.BmostrarProdu.Text = "Listar productos";
            this.BmostrarProdu.UseVisualStyleBackColor = false;
            this.BmostrarProdu.Click += new System.EventHandler(this.BmostrarProdu_Click);
            // 
            // Bproducto
            // 
            this.Bproducto.BackColor = System.Drawing.Color.SaddleBrown;
            this.Bproducto.Dock = System.Windows.Forms.DockStyle.Top;
            this.Bproducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bproducto.Font = new System.Drawing.Font("Script MT Bold", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bproducto.ForeColor = System.Drawing.Color.RosyBrown;
            this.Bproducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Bproducto.Location = new System.Drawing.Point(0, 556);
            this.Bproducto.Name = "Bproducto";
            this.Bproducto.Size = new System.Drawing.Size(365, 52);
            this.Bproducto.TabIndex = 3;
            this.Bproducto.Text = "Productos";
            this.Bproducto.UseVisualStyleBackColor = false;
            this.Bproducto.Click += new System.EventHandler(this.Bproducto_Click);
            // 
            // PsubmnClientes
            // 
            this.PsubmnClientes.BackColor = System.Drawing.Color.Sienna;
            this.PsubmnClientes.Controls.Add(this.BverC);
            this.PsubmnClientes.Controls.Add(this.BagregarC);
            this.PsubmnClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.PsubmnClientes.Font = new System.Drawing.Font("Script MT Bold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PsubmnClientes.ForeColor = System.Drawing.Color.LightCoral;
            this.PsubmnClientes.Location = new System.Drawing.Point(0, 444);
            this.PsubmnClientes.Name = "PsubmnClientes";
            this.PsubmnClientes.Size = new System.Drawing.Size(365, 112);
            this.PsubmnClientes.TabIndex = 2;
            this.PsubmnClientes.Visible = false;
            // 
            // BverC
            // 
            this.BverC.BackColor = System.Drawing.Color.Transparent;
            this.BverC.Dock = System.Windows.Forms.DockStyle.Top;
            this.BverC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BverC.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BverC.ForeColor = System.Drawing.Color.Black;
            this.BverC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BverC.Location = new System.Drawing.Point(0, 52);
            this.BverC.Name = "BverC";
            this.BverC.Size = new System.Drawing.Size(365, 48);
            this.BverC.TabIndex = 4;
            this.BverC.Text = "Listar clientes";
            this.BverC.UseVisualStyleBackColor = false;
            this.BverC.Click += new System.EventHandler(this.BverC_Click);
            // 
            // BagregarC
            // 
            this.BagregarC.BackColor = System.Drawing.Color.Transparent;
            this.BagregarC.Dock = System.Windows.Forms.DockStyle.Top;
            this.BagregarC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BagregarC.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BagregarC.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BagregarC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BagregarC.Location = new System.Drawing.Point(0, 0);
            this.BagregarC.Name = "BagregarC";
            this.BagregarC.Size = new System.Drawing.Size(365, 52);
            this.BagregarC.TabIndex = 2;
            this.BagregarC.Text = "Agregar cliente";
            this.BagregarC.UseVisualStyleBackColor = false;
            this.BagregarC.Click += new System.EventHandler(this.BagregarC_Click);
            // 
            // Bcliente
            // 
            this.Bcliente.BackColor = System.Drawing.Color.SaddleBrown;
            this.Bcliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.Bcliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bcliente.Font = new System.Drawing.Font("Script MT Bold", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bcliente.ForeColor = System.Drawing.Color.RosyBrown;
            this.Bcliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Bcliente.Location = new System.Drawing.Point(0, 392);
            this.Bcliente.Name = "Bcliente";
            this.Bcliente.Size = new System.Drawing.Size(365, 52);
            this.Bcliente.TabIndex = 1;
            this.Bcliente.Text = "Clientes";
            this.Bcliente.UseVisualStyleBackColor = false;
            this.Bcliente.Click += new System.EventHandler(this.Bcliente_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Sienna;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.BcerrarSesion);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(365, 392);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::SaborAcielo.Properties.Resources.EmpleadosInicio;
            this.pictureBox1.Location = new System.Drawing.Point(77, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 181);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BcerrarSesion
            // 
            this.BcerrarSesion.BackColor = System.Drawing.Color.RosyBrown;
            this.BcerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BcerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BcerrarSesion.Image = global::SaborAcielo.Properties.Resources.salir;
            this.BcerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BcerrarSesion.Location = new System.Drawing.Point(182, 6);
            this.BcerrarSesion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BcerrarSesion.Name = "BcerrarSesion";
            this.BcerrarSesion.Size = new System.Drawing.Size(149, 42);
            this.BcerrarSesion.TabIndex = 2;
            this.BcerrarSesion.Text = "Salir";
            this.BcerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BcerrarSesion.UseVisualStyleBackColor = false;
            this.BcerrarSesion.Click += new System.EventHandler(this.BcerrarSesion_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Script MT Bold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(131, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "empleado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido ";
            // 
            // PchildForm
            // 
            this.PchildForm.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PchildForm.BackgroundImage = global::SaborAcielo.Properties.Resources.fondoSACinicio;
            this.PchildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PchildForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PchildForm.Location = new System.Drawing.Point(365, 0);
            this.PchildForm.Name = "PchildForm";
            this.PchildForm.Size = new System.Drawing.Size(775, 892);
            this.PchildForm.TabIndex = 6;
            // 
            // MDIempleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 892);
            this.Controls.Add(this.PchildForm);
            this.Controls.Add(this.PmenuEmpleado);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MDIempleado";
            this.Text = "Empleado";
            this.PmenuEmpleado.ResumeLayout(false);
            this.PsubmnVentas.ResumeLayout(false);
            this.PsubmnProductos.ResumeLayout(false);
            this.PsubmnClientes.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Panel PmenuEmpleado;
        private System.Windows.Forms.Panel PsubmnVentas;
        private System.Windows.Forms.Button BlistarVenta;
        private System.Windows.Forms.Button BnuevaVenta;
        private System.Windows.Forms.Button Bventa;
        private System.Windows.Forms.Panel PsubmnProductos;
        private System.Windows.Forms.Button BmostrarProdu;
        private System.Windows.Forms.Button Bproducto;
        private System.Windows.Forms.Panel PsubmnClientes;
        private System.Windows.Forms.Button BverC;
        private System.Windows.Forms.Button BagregarC;
        private System.Windows.Forms.Button Bcliente;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BcerrarSesion;
        private System.Windows.Forms.Panel PchildForm;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}



