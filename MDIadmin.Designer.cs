﻿namespace SaborAcielo
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
            this.BcerrarSesion = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.PmenuLateral.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PmenuLateral.Name = "PmenuLateral";
            this.PmenuLateral.Size = new System.Drawing.Size(365, 892);
            this.PmenuLateral.TabIndex = 4;
            // 
            // PsubmClientes
            // 
            this.PsubmClientes.Controls.Add(this.BlistarClientes);
            this.PsubmClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.PsubmClientes.Location = new System.Drawing.Point(0, 801);
            this.PsubmClientes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PsubmClientes.Name = "PsubmClientes";
            this.PsubmClientes.Size = new System.Drawing.Size(365, 38);
            this.PsubmClientes.TabIndex = 8;
            this.PsubmClientes.Visible = false;
            // 
            // BlistarClientes
            // 
            this.BlistarClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.BlistarClientes.FlatAppearance.BorderSize = 0;
            this.BlistarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BlistarClientes.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlistarClientes.Location = new System.Drawing.Point(0, 0);
            this.BlistarClientes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BlistarClientes.Name = "BlistarClientes";
            this.BlistarClientes.Size = new System.Drawing.Size(365, 38);
            this.BlistarClientes.TabIndex = 0;
            this.BlistarClientes.Text = "Listar Clientes";
            this.BlistarClientes.UseVisualStyleBackColor = true;
            this.BlistarClientes.Click += new System.EventHandler(this.BlistarClientes_Click);
            // 
            // Bclientes
            // 
            this.Bclientes.BackColor = System.Drawing.Color.SaddleBrown;
            this.Bclientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.Bclientes.FlatAppearance.BorderSize = 0;
            this.Bclientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bclientes.Font = new System.Drawing.Font("Script MT Bold", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bclientes.ForeColor = System.Drawing.Color.RosyBrown;
            this.Bclientes.Location = new System.Drawing.Point(0, 742);
            this.Bclientes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Bclientes.Name = "Bclientes";
            this.Bclientes.Size = new System.Drawing.Size(365, 59);
            this.Bclientes.TabIndex = 7;
            this.Bclientes.Text = "Clientes";
            this.Bclientes.UseVisualStyleBackColor = false;
            this.Bclientes.Click += new System.EventHandler(this.Bclientes_Click);
            // 
            // PsubmVentas
            // 
            this.PsubmVentas.Controls.Add(this.BlistarVentas);
            this.PsubmVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.PsubmVentas.Location = new System.Drawing.Point(0, 700);
            this.PsubmVentas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PsubmVentas.Name = "PsubmVentas";
            this.PsubmVentas.Size = new System.Drawing.Size(365, 42);
            this.PsubmVentas.TabIndex = 6;
            this.PsubmVentas.Visible = false;
            // 
            // BlistarVentas
            // 
            this.BlistarVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.BlistarVentas.FlatAppearance.BorderSize = 0;
            this.BlistarVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BlistarVentas.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlistarVentas.Location = new System.Drawing.Point(0, 0);
            this.BlistarVentas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BlistarVentas.Name = "BlistarVentas";
            this.BlistarVentas.Size = new System.Drawing.Size(365, 42);
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
            this.Bventas.Font = new System.Drawing.Font("Script MT Bold", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bventas.ForeColor = System.Drawing.Color.RosyBrown;
            this.Bventas.Location = new System.Drawing.Point(0, 641);
            this.Bventas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Bventas.Name = "Bventas";
            this.Bventas.Size = new System.Drawing.Size(365, 59);
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
            this.PsubmProductos.Location = new System.Drawing.Point(0, 564);
            this.PsubmProductos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PsubmProductos.Name = "PsubmProductos";
            this.PsubmProductos.Size = new System.Drawing.Size(365, 77);
            this.PsubmProductos.TabIndex = 4;
            this.PsubmProductos.Visible = false;
            // 
            // BagregarProdu
            // 
            this.BagregarProdu.Dock = System.Windows.Forms.DockStyle.Top;
            this.BagregarProdu.FlatAppearance.BorderSize = 0;
            this.BagregarProdu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BagregarProdu.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BagregarProdu.Location = new System.Drawing.Point(0, 35);
            this.BagregarProdu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BagregarProdu.Name = "BagregarProdu";
            this.BagregarProdu.Size = new System.Drawing.Size(365, 42);
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
            this.BlistarProductos.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlistarProductos.Location = new System.Drawing.Point(0, 0);
            this.BlistarProductos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BlistarProductos.Name = "BlistarProductos";
            this.BlistarProductos.Size = new System.Drawing.Size(365, 35);
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
            this.Bproductos.Font = new System.Drawing.Font("Script MT Bold", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bproductos.ForeColor = System.Drawing.Color.RosyBrown;
            this.Bproductos.Location = new System.Drawing.Point(0, 505);
            this.Bproductos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Bproductos.Name = "Bproductos";
            this.Bproductos.Size = new System.Drawing.Size(365, 59);
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
            this.PsubmUsuarios.Location = new System.Drawing.Point(0, 420);
            this.PsubmUsuarios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PsubmUsuarios.Name = "PsubmUsuarios";
            this.PsubmUsuarios.Size = new System.Drawing.Size(365, 85);
            this.PsubmUsuarios.TabIndex = 2;
            this.PsubmUsuarios.Visible = false;
            // 
            // BagregarUsuarios
            // 
            this.BagregarUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.BagregarUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.BagregarUsuarios.FlatAppearance.BorderSize = 0;
            this.BagregarUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BagregarUsuarios.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BagregarUsuarios.Location = new System.Drawing.Point(0, 35);
            this.BagregarUsuarios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BagregarUsuarios.Name = "BagregarUsuarios";
            this.BagregarUsuarios.Size = new System.Drawing.Size(365, 36);
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
            this.BlistaUsuarios.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlistaUsuarios.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BlistaUsuarios.Location = new System.Drawing.Point(0, 0);
            this.BlistaUsuarios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BlistaUsuarios.Name = "BlistaUsuarios";
            this.BlistaUsuarios.Size = new System.Drawing.Size(365, 35);
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
            this.Busuarios.Font = new System.Drawing.Font("Script MT Bold", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Busuarios.ForeColor = System.Drawing.Color.RosyBrown;
            this.Busuarios.Location = new System.Drawing.Point(0, 364);
            this.Busuarios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Busuarios.Name = "Busuarios";
            this.Busuarios.Size = new System.Drawing.Size(365, 56);
            this.Busuarios.TabIndex = 1;
            this.Busuarios.Text = "Empleados";
            this.Busuarios.UseVisualStyleBackColor = false;
            this.Busuarios.Click += new System.EventHandler(this.Busuarios_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BcerrarSesion);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 364);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SaborAcielo.Properties.Resources.EmpleadosInicio;
            this.pictureBox1.Location = new System.Drawing.Point(92, 75);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 177);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // PchildAdmin
            // 
            this.PchildAdmin.BackgroundImage = global::SaborAcielo.Properties.Resources.fondoSACinicio;
            this.PchildAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PchildAdmin.Location = new System.Drawing.Point(365, 0);
            this.PchildAdmin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PchildAdmin.Name = "PchildAdmin";
            this.PchildAdmin.Size = new System.Drawing.Size(775, 892);
            this.PchildAdmin.TabIndex = 6;
            // 
            // BcerrarSesion
            // 
            this.BcerrarSesion.BackColor = System.Drawing.Color.RosyBrown;
            this.BcerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BcerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BcerrarSesion.Image = global::SaborAcielo.Properties.Resources.salir;
            this.BcerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BcerrarSesion.Location = new System.Drawing.Point(174, 5);
            this.BcerrarSesion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BcerrarSesion.Name = "BcerrarSesion";
            this.BcerrarSesion.Size = new System.Drawing.Size(149, 42);
            this.BcerrarSesion.TabIndex = 7;
            this.BcerrarSesion.Text = "Salir";
            this.BcerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BcerrarSesion.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Script MT Bold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(130, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "empleado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "Bienvenido ";
            // 
            // MDIadmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SaborAcielo.Properties.Resources.fondoSACinicio;
            this.ClientSize = new System.Drawing.Size(1140, 892);
            this.Controls.Add(this.PchildAdmin);
            this.Controls.Add(this.PmenuLateral);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MDIadmin";
            this.Text = "Administrador";
            this.PmenuLateral.ResumeLayout(false);
            this.PsubmClientes.ResumeLayout(false);
            this.PsubmVentas.ResumeLayout(false);
            this.PsubmProductos.ResumeLayout(false);
            this.PsubmUsuarios.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Button BcerrarSesion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}



