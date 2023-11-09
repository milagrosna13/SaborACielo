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
            this.Bproducto = new System.Windows.Forms.Button();
            this.Bven = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BcerrarSesion = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PchildForm = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.Sienna;
            this.panel1.Controls.Add(this.Bproducto);
            this.panel1.Controls.Add(this.Bven);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 487);
            this.panel1.TabIndex = 0;
            // 
            // Bproducto
            // 
            this.Bproducto.BackColor = System.Drawing.Color.SaddleBrown;
            this.Bproducto.Dock = System.Windows.Forms.DockStyle.Top;
            this.Bproducto.FlatAppearance.BorderSize = 0;
            this.Bproducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bproducto.Font = new System.Drawing.Font("Script MT Bold", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.Bproducto.ForeColor = System.Drawing.Color.RosyBrown;
            this.Bproducto.Location = new System.Drawing.Point(0, 293);
            this.Bproducto.Name = "Bproducto";
            this.Bproducto.Size = new System.Drawing.Size(243, 40);
            this.Bproducto.TabIndex = 3;
            this.Bproducto.Text = "Reporte Productos";
            this.Bproducto.UseVisualStyleBackColor = false;
            this.Bproducto.Click += new System.EventHandler(this.Bproducto_Click);
            // 
            // Bven
            // 
            this.Bven.BackColor = System.Drawing.Color.SaddleBrown;
            this.Bven.Dock = System.Windows.Forms.DockStyle.Top;
            this.Bven.FlatAppearance.BorderSize = 0;
            this.Bven.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bven.Font = new System.Drawing.Font("Script MT Bold", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bven.ForeColor = System.Drawing.Color.RosyBrown;
            this.Bven.Location = new System.Drawing.Point(0, 253);
            this.Bven.Name = "Bven";
            this.Bven.Size = new System.Drawing.Size(243, 40);
            this.Bven.TabIndex = 1;
            this.Bven.Text = "Reporte ventas";
            this.Bven.UseVisualStyleBackColor = false;
            this.Bven.Click += new System.EventHandler(this.Bvendedor_Click);
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
            this.panel2.Size = new System.Drawing.Size(243, 253);
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
            this.BcerrarSesion.Click += new System.EventHandler(this.BcerrarSesion_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Script MT Bold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(83, 216);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "gerente";
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
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MDIgerente_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Bven;
        private System.Windows.Forms.Button Bproducto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel PchildForm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BcerrarSesion;
    }
}