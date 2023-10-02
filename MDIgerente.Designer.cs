namespace SaborAcielo
{
    partial class MDIgerente
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Pventas = new System.Windows.Forms.Panel();
            this.BlistarVentas = new System.Windows.Forms.Button();
            this.Bventas = new System.Windows.Forms.Button();
            this.Pclientes = new System.Windows.Forms.Panel();
            this.BlistarClientes = new System.Windows.Forms.Button();
            this.Bclientes = new System.Windows.Forms.Button();
            this.Pprodu = new System.Windows.Forms.Panel();
            this.BagregarProdu = new System.Windows.Forms.Button();
            this.BlistarProdu = new System.Windows.Forms.Button();
            this.Bproducto = new System.Windows.Forms.Button();
            this.Pvendedores = new System.Windows.Forms.Panel();
            this.BeditarVendedor = new System.Windows.Forms.Button();
            this.BlistarVendedores = new System.Windows.Forms.Button();
            this.Bvendedor = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BcerrarSesion = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PchildForm = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.Pventas.SuspendLayout();
            this.Pclientes.SuspendLayout();
            this.Pprodu.SuspendLayout();
            this.Pvendedores.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.Sienna;
            this.panel1.Controls.Add(this.Pventas);
            this.panel1.Controls.Add(this.Bventas);
            this.panel1.Controls.Add(this.Pclientes);
            this.panel1.Controls.Add(this.Bclientes);
            this.panel1.Controls.Add(this.Pprodu);
            this.panel1.Controls.Add(this.Bproducto);
            this.panel1.Controls.Add(this.Pvendedores);
            this.panel1.Controls.Add(this.Bvendedor);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 487);
            this.panel1.TabIndex = 0;
            // 
            // Pventas
            // 
            this.Pventas.Controls.Add(this.BlistarVentas);
            this.Pventas.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pventas.Location = new System.Drawing.Point(0, 540);
            this.Pventas.Name = "Pventas";
            this.Pventas.Size = new System.Drawing.Size(226, 39);
            this.Pventas.TabIndex = 8;
            // 
            // BlistarVentas
            // 
            this.BlistarVentas.BackColor = System.Drawing.Color.Sienna;
            this.BlistarVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.BlistarVentas.FlatAppearance.BorderSize = 0;
            this.BlistarVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BlistarVentas.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlistarVentas.ForeColor = System.Drawing.Color.Black;
            this.BlistarVentas.Location = new System.Drawing.Point(0, 0);
            this.BlistarVentas.Name = "BlistarVentas";
            this.BlistarVentas.Size = new System.Drawing.Size(226, 23);
            this.BlistarVentas.TabIndex = 0;
            this.BlistarVentas.Text = "Listar ventas";
            this.BlistarVentas.UseVisualStyleBackColor = false;
            this.BlistarVentas.Click += new System.EventHandler(this.BlistarVentas_Click);
            // 
            // Bventas
            // 
            this.Bventas.BackColor = System.Drawing.Color.SaddleBrown;
            this.Bventas.Dock = System.Windows.Forms.DockStyle.Top;
            this.Bventas.FlatAppearance.BorderSize = 0;
            this.Bventas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bventas.Font = new System.Drawing.Font("Script MT Bold", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.Bventas.ForeColor = System.Drawing.Color.RosyBrown;
            this.Bventas.Location = new System.Drawing.Point(0, 506);
            this.Bventas.Name = "Bventas";
            this.Bventas.Size = new System.Drawing.Size(226, 34);
            this.Bventas.TabIndex = 7;
            this.Bventas.Text = "Ventas";
            this.Bventas.UseVisualStyleBackColor = false;
            this.Bventas.Click += new System.EventHandler(this.Bventas_Click);
            // 
            // Pclientes
            // 
            this.Pclientes.Controls.Add(this.BlistarClientes);
            this.Pclientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pclientes.Location = new System.Drawing.Point(0, 478);
            this.Pclientes.Name = "Pclientes";
            this.Pclientes.Size = new System.Drawing.Size(226, 28);
            this.Pclientes.TabIndex = 6;
            this.Pclientes.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // BlistarClientes
            // 
            this.BlistarClientes.BackColor = System.Drawing.Color.Transparent;
            this.BlistarClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.BlistarClientes.FlatAppearance.BorderSize = 0;
            this.BlistarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BlistarClientes.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlistarClientes.Location = new System.Drawing.Point(0, 0);
            this.BlistarClientes.Name = "BlistarClientes";
            this.BlistarClientes.Size = new System.Drawing.Size(226, 25);
            this.BlistarClientes.TabIndex = 0;
            this.BlistarClientes.Text = "Listar clientes";
            this.BlistarClientes.UseVisualStyleBackColor = false;
            this.BlistarClientes.Click += new System.EventHandler(this.BlistarClientes_Click);
            // 
            // Bclientes
            // 
            this.Bclientes.BackColor = System.Drawing.Color.SaddleBrown;
            this.Bclientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.Bclientes.FlatAppearance.BorderSize = 0;
            this.Bclientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bclientes.Font = new System.Drawing.Font("Script MT Bold", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.Bclientes.ForeColor = System.Drawing.Color.RosyBrown;
            this.Bclientes.Location = new System.Drawing.Point(0, 438);
            this.Bclientes.Name = "Bclientes";
            this.Bclientes.Size = new System.Drawing.Size(226, 40);
            this.Bclientes.TabIndex = 5;
            this.Bclientes.Text = "Clientes";
            this.Bclientes.UseVisualStyleBackColor = false;
            this.Bclientes.Click += new System.EventHandler(this.Bclientes_Click);
            // 
            // Pprodu
            // 
            this.Pprodu.Controls.Add(this.BagregarProdu);
            this.Pprodu.Controls.Add(this.BlistarProdu);
            this.Pprodu.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pprodu.Location = new System.Drawing.Point(0, 384);
            this.Pprodu.Name = "Pprodu";
            this.Pprodu.Size = new System.Drawing.Size(226, 54);
            this.Pprodu.TabIndex = 4;
            this.Pprodu.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // BagregarProdu
            // 
            this.BagregarProdu.BackColor = System.Drawing.Color.Transparent;
            this.BagregarProdu.Dock = System.Windows.Forms.DockStyle.Top;
            this.BagregarProdu.FlatAppearance.BorderSize = 0;
            this.BagregarProdu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BagregarProdu.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BagregarProdu.Location = new System.Drawing.Point(0, 23);
            this.BagregarProdu.Name = "BagregarProdu";
            this.BagregarProdu.Size = new System.Drawing.Size(226, 24);
            this.BagregarProdu.TabIndex = 1;
            this.BagregarProdu.Text = "Agregar producto";
            this.BagregarProdu.UseVisualStyleBackColor = false;
            this.BagregarProdu.Click += new System.EventHandler(this.BagregarProdu_Click);
            // 
            // BlistarProdu
            // 
            this.BlistarProdu.BackColor = System.Drawing.Color.Transparent;
            this.BlistarProdu.Dock = System.Windows.Forms.DockStyle.Top;
            this.BlistarProdu.FlatAppearance.BorderSize = 0;
            this.BlistarProdu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BlistarProdu.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlistarProdu.Location = new System.Drawing.Point(0, 0);
            this.BlistarProdu.Name = "BlistarProdu";
            this.BlistarProdu.Size = new System.Drawing.Size(226, 23);
            this.BlistarProdu.TabIndex = 0;
            this.BlistarProdu.Text = "Listar Productos";
            this.BlistarProdu.UseVisualStyleBackColor = false;
            this.BlistarProdu.Click += new System.EventHandler(this.BlistarProdu_Click);
            // 
            // Bproducto
            // 
            this.Bproducto.BackColor = System.Drawing.Color.SaddleBrown;
            this.Bproducto.Dock = System.Windows.Forms.DockStyle.Top;
            this.Bproducto.FlatAppearance.BorderSize = 0;
            this.Bproducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bproducto.Font = new System.Drawing.Font("Script MT Bold", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.Bproducto.ForeColor = System.Drawing.Color.RosyBrown;
            this.Bproducto.Location = new System.Drawing.Point(0, 344);
            this.Bproducto.Name = "Bproducto";
            this.Bproducto.Size = new System.Drawing.Size(226, 40);
            this.Bproducto.TabIndex = 3;
            this.Bproducto.Text = "Productos";
            this.Bproducto.UseVisualStyleBackColor = false;
            this.Bproducto.Click += new System.EventHandler(this.Bproducto_Click);
            // 
            // Pvendedores
            // 
            this.Pvendedores.Controls.Add(this.BeditarVendedor);
            this.Pvendedores.Controls.Add(this.BlistarVendedores);
            this.Pvendedores.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pvendedores.Location = new System.Drawing.Point(0, 293);
            this.Pvendedores.Name = "Pvendedores";
            this.Pvendedores.Size = new System.Drawing.Size(226, 51);
            this.Pvendedores.TabIndex = 2;
            // 
            // BeditarVendedor
            // 
            this.BeditarVendedor.BackColor = System.Drawing.Color.Transparent;
            this.BeditarVendedor.Dock = System.Windows.Forms.DockStyle.Top;
            this.BeditarVendedor.FlatAppearance.BorderSize = 0;
            this.BeditarVendedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BeditarVendedor.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BeditarVendedor.Location = new System.Drawing.Point(0, 23);
            this.BeditarVendedor.Name = "BeditarVendedor";
            this.BeditarVendedor.Size = new System.Drawing.Size(226, 22);
            this.BeditarVendedor.TabIndex = 1;
            this.BeditarVendedor.Text = "Editar vendedor";
            this.BeditarVendedor.UseVisualStyleBackColor = false;
            this.BeditarVendedor.Click += new System.EventHandler(this.BeditarVendedor_Click);
            // 
            // BlistarVendedores
            // 
            this.BlistarVendedores.BackColor = System.Drawing.Color.Transparent;
            this.BlistarVendedores.Dock = System.Windows.Forms.DockStyle.Top;
            this.BlistarVendedores.FlatAppearance.BorderSize = 0;
            this.BlistarVendedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BlistarVendedores.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlistarVendedores.Location = new System.Drawing.Point(0, 0);
            this.BlistarVendedores.Name = "BlistarVendedores";
            this.BlistarVendedores.Size = new System.Drawing.Size(226, 23);
            this.BlistarVendedores.TabIndex = 0;
            this.BlistarVendedores.Text = "Listar vendedores";
            this.BlistarVendedores.UseVisualStyleBackColor = false;
            this.BlistarVendedores.Click += new System.EventHandler(this.BlistarVendedores_Click);
            // 
            // Bvendedor
            // 
            this.Bvendedor.BackColor = System.Drawing.Color.SaddleBrown;
            this.Bvendedor.Dock = System.Windows.Forms.DockStyle.Top;
            this.Bvendedor.FlatAppearance.BorderSize = 0;
            this.Bvendedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bvendedor.Font = new System.Drawing.Font("Script MT Bold", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bvendedor.ForeColor = System.Drawing.Color.RosyBrown;
            this.Bvendedor.Location = new System.Drawing.Point(0, 253);
            this.Bvendedor.Name = "Bvendedor";
            this.Bvendedor.Size = new System.Drawing.Size(226, 40);
            this.Bvendedor.TabIndex = 1;
            this.Bvendedor.Text = "Vendedores";
            this.Bvendedor.UseVisualStyleBackColor = false;
            this.Bvendedor.Click += new System.EventHandler(this.Bvendedor_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BcerrarSesion);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(226, 253);
            this.panel2.TabIndex = 0;
            // 
            // BcerrarSesion
            // 
            this.BcerrarSesion.BackColor = System.Drawing.Color.RosyBrown;
            this.BcerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BcerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BcerrarSesion.Image = global::SaborAcielo.Properties.Resources.salir;
            this.BcerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BcerrarSesion.Location = new System.Drawing.Point(139, 3);
            this.BcerrarSesion.Name = "BcerrarSesion";
            this.BcerrarSesion.Size = new System.Drawing.Size(99, 27);
            this.BcerrarSesion.TabIndex = 4;
            this.BcerrarSesion.Text = "Salir";
            this.BcerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BcerrarSesion.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Script MT Bold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(83, 216);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "empleado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 185);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bienvenido ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::SaborAcielo.Properties.Resources.EmpleadosInicio;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(57, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 115);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // PchildForm
            // 
            this.PchildForm.BackgroundImage = global::SaborAcielo.Properties.Resources.fondoSACinicio;
            this.PchildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PchildForm.Location = new System.Drawing.Point(243, 0);
            this.PchildForm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PchildForm.Name = "PchildForm";
            this.PchildForm.Size = new System.Drawing.Size(517, 487);
            this.PchildForm.TabIndex = 1;
            // 
            // MDIgerente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 487);
            this.Controls.Add(this.PchildForm);
            this.Controls.Add(this.panel1);
            this.Name = "MDIgerente";
            this.Text = "Gerente";
            this.Load += new System.EventHandler(this.MDIgerente_Load);
            this.panel1.ResumeLayout(false);
            this.Pventas.ResumeLayout(false);
            this.Pclientes.ResumeLayout(false);
            this.Pprodu.ResumeLayout(false);
            this.Pvendedores.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel Pvendedores;
        private System.Windows.Forms.Button Bvendedor;
        private System.Windows.Forms.Button Bclientes;
        private System.Windows.Forms.Panel Pprodu;
        private System.Windows.Forms.Button Bproducto;
        private System.Windows.Forms.Button BlistarVendedores;
        private System.Windows.Forms.Button BeditarVendedor;
        private System.Windows.Forms.Panel Pclientes;
        private System.Windows.Forms.Button BlistarClientes;
        private System.Windows.Forms.Button BagregarProdu;
        private System.Windows.Forms.Button BlistarProdu;
        private System.Windows.Forms.Button Bventas;
        private System.Windows.Forms.Panel Pventas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BlistarVentas;
        private System.Windows.Forms.Panel PchildForm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BcerrarSesion;
    }
}