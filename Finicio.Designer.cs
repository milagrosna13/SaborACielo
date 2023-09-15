namespace SaborAcielo
{
    partial class Finicio
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Tusuario = new System.Windows.Forms.TextBox();
            this.Tcontraseña = new System.Windows.Forms.TextBox();
            this.Bingresar = new System.Windows.Forms.Button();
            this.Bcerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 30F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(180, 156);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sabor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Script MT Bold", 30F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(362, 156);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 72);
            this.label2.TabIndex = 1;
            this.label2.Text = "a";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Script MT Bold", 30F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(243, 216);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 72);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cielo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Script MT Bold", 22F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(141, 310);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 53);
            this.label4.TabIndex = 3;
            this.label4.Text = "Usuario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Script MT Bold", 22F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(132, 392);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(217, 53);
            this.label5.TabIndex = 4;
            this.label5.Text = "Contraseña";
            // 
            // Tusuario
            // 
            this.Tusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Tusuario.Location = new System.Drawing.Point(369, 332);
            this.Tusuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Tusuario.Name = "Tusuario";
            this.Tusuario.Size = new System.Drawing.Size(313, 41);
            this.Tusuario.TabIndex = 5;
            // 
            // Tcontraseña
            // 
            this.Tcontraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Tcontraseña.Location = new System.Drawing.Point(369, 402);
            this.Tcontraseña.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Tcontraseña.Name = "Tcontraseña";
            this.Tcontraseña.Size = new System.Drawing.Size(313, 41);
            this.Tcontraseña.TabIndex = 6;
            // 
            // Bingresar
            // 
            this.Bingresar.BackColor = System.Drawing.Color.Transparent;
            this.Bingresar.FlatAppearance.BorderSize = 0;
            this.Bingresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Bingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bingresar.Font = new System.Drawing.Font("Script MT Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bingresar.Image = global::SaborAcielo.Properties.Resources.botonpildora;
            this.Bingresar.Location = new System.Drawing.Point(306, 594);
            this.Bingresar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Bingresar.Name = "Bingresar";
            this.Bingresar.Size = new System.Drawing.Size(231, 77);
            this.Bingresar.TabIndex = 7;
            this.Bingresar.Text = "Ingresar";
            this.Bingresar.UseVisualStyleBackColor = false;
            this.Bingresar.Click += new System.EventHandler(this.Bingresar_Click);
            // 
            // Bcerrar
            // 
            this.Bcerrar.BackColor = System.Drawing.Color.Transparent;
            this.Bcerrar.FlatAppearance.BorderSize = 0;
            this.Bcerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Bcerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bcerrar.Image = global::SaborAcielo.Properties.Resources.cruz;
            this.Bcerrar.Location = new System.Drawing.Point(756, 18);
            this.Bcerrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Bcerrar.Name = "Bcerrar";
            this.Bcerrar.Size = new System.Drawing.Size(70, 78);
            this.Bcerrar.TabIndex = 8;
            this.Bcerrar.UseVisualStyleBackColor = false;
            this.Bcerrar.Click += new System.EventHandler(this.Bcerrar_Click);
            // 
            // Finicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SaborAcielo.Properties.Resources.saboracielo2;
            this.ClientSize = new System.Drawing.Size(844, 842);
            this.ControlBox = false;
            this.Controls.Add(this.Bcerrar);
            this.Controls.Add(this.Bingresar);
            this.Controls.Add(this.Tcontraseña);
            this.Controls.Add(this.Tusuario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Finicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Tusuario;
        private System.Windows.Forms.TextBox Tcontraseña;
        private System.Windows.Forms.Button Bingresar;
        private System.Windows.Forms.Button Bcerrar;
    }
}

