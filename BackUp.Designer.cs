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
            this.BbackUp = new System.Windows.Forms.Button();
            this.Brestaurar = new System.Windows.Forms.Button();
            this.txtBackUpPath = new System.Windows.Forms.TextBox();
            this.txtRestorePath = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // Lservidor
            // 
            this.Lservidor.AutoSize = true;
            this.Lservidor.BackColor = System.Drawing.Color.Transparent;
            this.Lservidor.Font = new System.Drawing.Font("Script MT Bold", 25F, System.Drawing.FontStyle.Bold);
            this.Lservidor.Location = new System.Drawing.Point(114, 45);
            this.Lservidor.Name = "Lservidor";
            this.Lservidor.Size = new System.Drawing.Size(135, 41);
            this.Lservidor.TabIndex = 0;
            this.Lservidor.Text = "BackUp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(114, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Restaurar";
            // 
            // BbackUp
            // 
            this.BbackUp.BackColor = System.Drawing.Color.LightCoral;
            this.BbackUp.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.BbackUp.FlatAppearance.BorderSize = 0;
            this.BbackUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BbackUp.Font = new System.Drawing.Font("Script MT Bold", 18.75F, System.Drawing.FontStyle.Bold);
            this.BbackUp.Location = new System.Drawing.Point(305, 162);
            this.BbackUp.Name = "BbackUp";
            this.BbackUp.Size = new System.Drawing.Size(125, 47);
            this.BbackUp.TabIndex = 4;
            this.BbackUp.Text = "Back Up";
            this.BbackUp.UseVisualStyleBackColor = false;
            this.BbackUp.Click += new System.EventHandler(this.BbackUp_Click);
            // 
            // Brestaurar
            // 
            this.Brestaurar.BackColor = System.Drawing.Color.LightCoral;
            this.Brestaurar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.Brestaurar.FlatAppearance.BorderSize = 0;
            this.Brestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Brestaurar.Font = new System.Drawing.Font("Script MT Bold", 18.75F, System.Drawing.FontStyle.Bold);
            this.Brestaurar.Location = new System.Drawing.Point(305, 388);
            this.Brestaurar.Name = "Brestaurar";
            this.Brestaurar.Size = new System.Drawing.Size(125, 47);
            this.Brestaurar.TabIndex = 5;
            this.Brestaurar.Text = "Restaurar";
            this.Brestaurar.UseVisualStyleBackColor = false;
            this.Brestaurar.Click += new System.EventHandler(this.Brestaurar_Click);
            // 
            // txtBackUpPath
            // 
            this.txtBackUpPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtBackUpPath.Location = new System.Drawing.Point(305, 95);
            this.txtBackUpPath.Name = "txtBackUpPath";
            this.txtBackUpPath.Size = new System.Drawing.Size(354, 30);
            this.txtBackUpPath.TabIndex = 6;
            // 
            // txtRestorePath
            // 
            this.txtRestorePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtRestorePath.Location = new System.Drawing.Point(305, 313);
            this.txtRestorePath.Name = "txtRestorePath";
            this.txtRestorePath.Size = new System.Drawing.Size(354, 30);
            this.txtRestorePath.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MintCream;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.LightCyan;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Script MT Bold", 15.75F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(156, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 30);
            this.button1.TabIndex = 8;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MintCream;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.MintCream;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Script MT Bold", 15.75F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(156, 313);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 30);
            this.button2.TabIndex = 9;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // BackUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SaborAcielo.Properties.Resources.fondoSACinicio;
            this.ClientSize = new System.Drawing.Size(810, 538);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtRestorePath);
            this.Controls.Add(this.txtBackUpPath);
            this.Controls.Add(this.Brestaurar);
            this.Controls.Add(this.BbackUp);
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
        private System.Windows.Forms.Button BbackUp;
        private System.Windows.Forms.Button Brestaurar;
        private System.Windows.Forms.TextBox txtBackUpPath;
        private System.Windows.Forms.TextBox txtRestorePath;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}