namespace SaborAcielo
{
    partial class MDIadmin
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
            this.PmenuLateral = new System.Windows.Forms.Panel();
            this.PsubmClientes = new System.Windows.Forms.Panel();
            this.BlistarClientes = new System.Windows.Forms.Button();
            this.Bclientes = new System.Windows.Forms.Button();
            this.PsubmVentas = new System.Windows.Forms.Panel();
            this.BlistarVentas = new System.Windows.Forms.Button();
            this.Bventas = new System.Windows.Forms.Button();
            this.PsubmProductos = new System.Windows.Forms.Panel();
            this.BagregarProdu = new System.Windows.Forms.Button();
            this.BlistarProductos = new System.Windows.Forms.Button();
            this.Bproductos = new System.Windows.Forms.Button();
            this.PsubmUsuarios = new System.Windows.Forms.Panel();
            this.BagregarUsuarios = new System.Windows.Forms.Button();
            this.BlistaUsuarios = new System.Windows.Forms.Button();
            this.Busuarios = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PchildAdmin = new System.Windows.Forms.Panel();
            this.PmenuLateral.SuspendLayout();
            this.PsubmClientes.SuspendLayout();
            this.PsubmVentas.SuspendLayout();
            this.PsubmProductos.SuspendLayout();
            this.PsubmUsuarios.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PmenuLateral
            // 
            this.PmenuLateral.AutoScroll = true;
            this.PmenuLateral.BackColor = System.Drawing.Color.Sienna;
            this.PmenuLateral.Controls.Add(this.PsubmClientes);
            this.PmenuLateral.Controls.Add(this.Bclientes);
            this.PmenuLateral.Controls.Add(this.PsubmVentas);
            this.PmenuLateral.Controls.Add(this.Bventas);
            this.PmenuLateral.Controls.Add(this.PsubmProductos);
            this.PmenuLateral.Controls.Add(this.Bproductos);
            this.PmenuLateral.Controls.Add(this.PsubmUsuarios);
            this.PmenuLateral.Controls.Add(this.Busuarios);
            this.PmenuLateral.Controls.Add(this.panel1);
            this.PmenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.PmenuLateral.Location = new System.Drawing.Point(0, 0);
            this.PmenuLateral.Name = "PmenuLateral";
            this.PmenuLateral.Size = new System.Drawing.Size(243, 550);
            this.PmenuLateral.TabIndex = 4;
            // 
            // PsubmClientes
            // 
            this.PsubmClientes.Controls.Add(this.BlistarClientes);
            this.PsubmClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.PsubmClientes.Location = new System.Drawing.Point(0, 495);
            this.PsubmClientes.Name = "PsubmClientes";
            this.PsubmClientes.Size = new System.Drawing.Size(243, 25);
            this.PsubmClientes.TabIndex = 8;
            this.PsubmClientes.Visible = false;
            // 
            // BlistarClientes
            // 
            this.BlistarClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.BlistarClientes.FlatAppearance.BorderSize = 0;
            this.BlistarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BlistarClientes.Location = new System.Drawing.Point(0, 0);
            this.BlistarClientes.Name = "BlistarClientes";
            this.BlistarClientes.Size = new System.Drawing.Size(243, 25);
            this.BlistarClientes.TabIndex = 0;
            this.BlistarClientes.Text = "Listar CLientes";
            this.BlistarClientes.UseVisualStyleBackColor = true;
            this.BlistarClientes.Click += new System.EventHandler(this.BlistarClientes_Click);
            // 
            // Bclientes
            // 
            this.Bclientes.BackColor = System.Drawing.Color.SaddleBrown;
            this.Bclientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.Bclientes.FlatAppearance.BorderSize = 0;
            this.Bclientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bclientes.Font = new System.Drawing.Font("Script MT Bold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bclientes.ForeColor = System.Drawing.Color.RosyBrown;
            this.Bclientes.Location = new System.Drawing.Point(0, 450);
            this.Bclientes.Name = "Bclientes";
            this.Bclientes.Size = new System.Drawing.Size(243, 45);
            this.Bclientes.TabIndex = 7;
            this.Bclientes.Text = "Clientes";
            this.Bclientes.UseVisualStyleBackColor = false;
            this.Bclientes.Click += new System.EventHandler(this.Bclientes_Click);
            // 
            // PsubmVentas
            // 
            this.PsubmVentas.Controls.Add(this.BlistarVentas);
            this.PsubmVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.PsubmVentas.Location = new System.Drawing.Point(0, 423);
            this.PsubmVentas.Name = "PsubmVentas";
            this.PsubmVentas.Size = new System.Drawing.Size(243, 27);
            this.PsubmVentas.TabIndex = 6;
            this.PsubmVentas.Visible = false;
            // 
            // BlistarVentas
            // 
            this.BlistarVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.BlistarVentas.FlatAppearance.BorderSize = 0;
            this.BlistarVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BlistarVentas.Location = new System.Drawing.Point(0, 0);
            this.BlistarVentas.Name = "BlistarVentas";
            this.BlistarVentas.Size = new System.Drawing.Size(243, 27);
            this.BlistarVentas.TabIndex = 0;
            this.BlistarVentas.Text = "Listar Ventas";
            this.BlistarVentas.UseVisualStyleBackColor = true;
            // 
            // Bventas
            // 
            this.Bventas.BackColor = System.Drawing.Color.SaddleBrown;
            this.Bventas.Dock = System.Windows.Forms.DockStyle.Top;
            this.Bventas.FlatAppearance.BorderSize = 0;
            this.Bventas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bventas.Font = new System.Drawing.Font("Script MT Bold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bventas.ForeColor = System.Drawing.Color.RosyBrown;
            this.Bventas.Location = new System.Drawing.Point(0, 378);
            this.Bventas.Name = "Bventas";
            this.Bventas.Size = new System.Drawing.Size(243, 45);
            this.Bventas.TabIndex = 5;
            this.Bventas.Text = "Ventas";
            this.Bventas.UseVisualStyleBackColor = false;
            this.Bventas.Click += new System.EventHandler(this.Bventas_Click);
            // 
            // PsubmProductos
            // 
            this.PsubmProductos.Controls.Add(this.BagregarProdu);
            this.PsubmProductos.Controls.Add(this.BlistarProductos);
            this.PsubmProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.PsubmProductos.Location = new System.Drawing.Point(0, 328);
            this.PsubmProductos.Name = "PsubmProductos";
            this.PsubmProductos.Size = new System.Drawing.Size(243, 50);
            this.PsubmProductos.TabIndex = 4;
            this.PsubmProductos.Visible = false;
            // 
            // BagregarProdu
            // 
            this.BagregarProdu.Dock = System.Windows.Forms.DockStyle.Top;
            this.BagregarProdu.FlatAppearance.BorderSize = 0;
            this.BagregarProdu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BagregarProdu.Location = new System.Drawing.Point(0, 23);
            this.BagregarProdu.Name = "BagregarProdu";
            this.BagregarProdu.Size = new System.Drawing.Size(243, 27);
            this.BagregarProdu.TabIndex = 1;
            this.BagregarProdu.Text = "Agregar Productos";
            this.BagregarProdu.UseVisualStyleBackColor = true;
            this.BagregarProdu.Click += new System.EventHandler(this.BagregarProdu_Click);
            // 
            // BlistarProductos
            // 
            this.BlistarProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.BlistarProductos.FlatAppearance.BorderSize = 0;
            this.BlistarProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BlistarProductos.Location = new System.Drawing.Point(0, 0);
            this.BlistarProductos.Name = "BlistarProductos";
            this.BlistarProductos.Size = new System.Drawing.Size(243, 23);
            this.BlistarProductos.TabIndex = 0;
            this.BlistarProductos.Text = "Listar Productos";
            this.BlistarProductos.UseVisualStyleBackColor = true;
            this.BlistarProductos.Click += new System.EventHandler(this.BlistarProductos_Click);
            // 
            // Bproductos
            // 
            this.Bproductos.BackColor = System.Drawing.Color.SaddleBrown;
            this.Bproductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.Bproductos.FlatAppearance.BorderSize = 0;
            this.Bproductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bproductos.Font = new System.Drawing.Font("Script MT Bold", 15F, System.Drawing.FontStyle.Bold);
            this.Bproductos.ForeColor = System.Drawing.Color.RosyBrown;
            this.Bproductos.Location = new System.Drawing.Point(0, 283);
            this.Bproductos.Name = "Bproductos";
            this.Bproductos.Size = new System.Drawing.Size(243, 45);
            this.Bproductos.TabIndex = 3;
            this.Bproductos.Text = "Productos";
            this.Bproductos.UseVisualStyleBackColor = false;
            this.Bproductos.Click += new System.EventHandler(this.Bproductos_Click);
            // 
            // PsubmUsuarios
            // 
            this.PsubmUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.PsubmUsuarios.Controls.Add(this.BagregarUsuarios);
            this.PsubmUsuarios.Controls.Add(this.BlistaUsuarios);
            this.PsubmUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.PsubmUsuarios.Location = new System.Drawing.Point(0, 237);
            this.PsubmUsuarios.Name = "PsubmUsuarios";
            this.PsubmUsuarios.Size = new System.Drawing.Size(243, 46);
            this.PsubmUsuarios.TabIndex = 2;
            this.PsubmUsuarios.Visible = false;
            // 
            // BagregarUsuarios
            // 
            this.BagregarUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.BagregarUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.BagregarUsuarios.FlatAppearance.BorderSize = 0;
            this.BagregarUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BagregarUsuarios.Location = new System.Drawing.Point(0, 23);
            this.BagregarUsuarios.Name = "BagregarUsuarios";
            this.BagregarUsuarios.Size = new System.Drawing.Size(243, 23);
            this.BagregarUsuarios.TabIndex = 1;
            this.BagregarUsuarios.Text = "Agregar empleado";
            this.BagregarUsuarios.UseVisualStyleBackColor = false;
            this.BagregarUsuarios.Click += new System.EventHandler(this.BagregarUsuarios_Click);
            // 
            // BlistaUsuarios
            // 
            this.BlistaUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.BlistaUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.BlistaUsuarios.FlatAppearance.BorderSize = 0;
            this.BlistaUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BlistaUsuarios.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlistaUsuarios.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BlistaUsuarios.Location = new System.Drawing.Point(0, 0);
            this.BlistaUsuarios.Name = "BlistaUsuarios";
            this.BlistaUsuarios.Size = new System.Drawing.Size(243, 23);
            this.BlistaUsuarios.TabIndex = 0;
            this.BlistaUsuarios.Text = "Listar empleados";
            this.BlistaUsuarios.UseVisualStyleBackColor = false;
            this.BlistaUsuarios.Click += new System.EventHandler(this.BlistaUsuarios_Click);
            // 
            // Busuarios
            // 
            this.Busuarios.BackColor = System.Drawing.Color.SaddleBrown;
            this.Busuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.Busuarios.FlatAppearance.BorderSize = 0;
            this.Busuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Busuarios.Font = new System.Drawing.Font("Script MT Bold", 15F, System.Drawing.FontStyle.Bold);
            this.Busuarios.ForeColor = System.Drawing.Color.RosyBrown;
            this.Busuarios.Location = new System.Drawing.Point(0, 192);
            this.Busuarios.Name = "Busuarios";
            this.Busuarios.Size = new System.Drawing.Size(243, 45);
            this.Busuarios.TabIndex = 1;
            this.Busuarios.Text = "Empleados";
            this.Busuarios.UseVisualStyleBackColor = false;
            this.Busuarios.Click += new System.EventHandler(this.Busuarios_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 192);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SaborAcielo.Properties.Resources.EmpleadosInicio;
            this.pictureBox1.Location = new System.Drawing.Point(52, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // PchildAdmin
            // 
            this.PchildAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PchildAdmin.Location = new System.Drawing.Point(243, 0);
            this.PchildAdmin.Name = "PchildAdmin";
            this.PchildAdmin.Size = new System.Drawing.Size(531, 550);
            this.PchildAdmin.TabIndex = 6;
            // 
            // MDIadmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SaborAcielo.Properties.Resources.fondoSACinicio;
            this.ClientSize = new System.Drawing.Size(774, 550);
            this.Controls.Add(this.PchildAdmin);
            this.Controls.Add(this.PmenuLateral);
            this.IsMdiContainer = true;
            this.Name = "MDIadmin";
            this.Text = "Administrador";
            this.PmenuLateral.ResumeLayout(false);
            this.PsubmClientes.ResumeLayout(false);
            this.PsubmVentas.ResumeLayout(false);
            this.PsubmProductos.ResumeLayout(false);
            this.PsubmUsuarios.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Panel PmenuLateral;
        private System.Windows.Forms.Panel PsubmUsuarios;
        private System.Windows.Forms.Button Busuarios;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PsubmProductos;
        private System.Windows.Forms.Button BlistarProductos;
        private System.Windows.Forms.Button Bproductos;
        private System.Windows.Forms.Button BagregarUsuarios;
        private System.Windows.Forms.Button BlistaUsuarios;
        private System.Windows.Forms.Button BagregarProdu;
        private System.Windows.Forms.Panel PsubmVentas;
        private System.Windows.Forms.Button BlistarVentas;
        private System.Windows.Forms.Button Bventas;
        private System.Windows.Forms.Button Bclientes;
        private System.Windows.Forms.Panel PsubmClientes;
        private System.Windows.Forms.Button BlistarClientes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel PchildAdmin;
    }
}



