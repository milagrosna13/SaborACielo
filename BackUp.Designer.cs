namespace SaborAcielo
{
    partial class BackUp
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
            this.Lservidor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.BbackUp = new System.Windows.Forms.Button();
            this.Brestaurar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lservidor
            // 
            this.Lservidor.AutoSize = true;
            this.Lservidor.BackColor = System.Drawing.Color.Transparent;
            this.Lservidor.Font = new System.Drawing.Font("Script MT Bold", 25F, System.Drawing.FontStyle.Bold);
            this.Lservidor.Location = new System.Drawing.Point(143, 107);
            this.Lservidor.Name = "Lservidor";
            this.Lservidor.Size = new System.Drawing.Size(129, 41);
            this.Lservidor.TabIndex = 0;
            this.Lservidor.Text = "Servidor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(143, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Base de datos";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(412, 124);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(256, 33);
            this.comboBox1.TabIndex = 2;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(412, 202);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(256, 33);
            this.comboBox2.TabIndex = 3;
            // 
            // BbackUp
            // 
            this.BbackUp.BackColor = System.Drawing.Color.LightCoral;
            this.BbackUp.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.BbackUp.FlatAppearance.BorderSize = 0;
            this.BbackUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BbackUp.Font = new System.Drawing.Font("Script MT Bold", 18.75F, System.Drawing.FontStyle.Bold);
            this.BbackUp.Location = new System.Drawing.Point(466, 366);
            this.BbackUp.Name = "BbackUp";
            this.BbackUp.Size = new System.Drawing.Size(125, 47);
            this.BbackUp.TabIndex = 4;
            this.BbackUp.Text = "Back Up";
            this.BbackUp.UseVisualStyleBackColor = false;
            // 
            // Brestaurar
            // 
            this.Brestaurar.BackColor = System.Drawing.Color.LightCoral;
            this.Brestaurar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.Brestaurar.FlatAppearance.BorderSize = 0;
            this.Brestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Brestaurar.Font = new System.Drawing.Font("Script MT Bold", 18.75F, System.Drawing.FontStyle.Bold);
            this.Brestaurar.Location = new System.Drawing.Point(184, 366);
            this.Brestaurar.Name = "Brestaurar";
            this.Brestaurar.Size = new System.Drawing.Size(125, 47);
            this.Brestaurar.TabIndex = 5;
            this.Brestaurar.Text = "Restaurar";
            this.Brestaurar.UseVisualStyleBackColor = false;
            // 
            // BackUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SaborAcielo.Properties.Resources.fondoSACinicio;
            this.ClientSize = new System.Drawing.Size(810, 538);
            this.Controls.Add(this.Brestaurar);
            this.Controls.Add(this.BbackUp);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lservidor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BackUp";
            this.Text = "BackUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lservidor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button BbackUp;
        private System.Windows.Forms.Button Brestaurar;
    }
}