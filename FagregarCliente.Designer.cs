namespace SaborAcielo
{
    partial class FagregarCliente
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BguardarCliente = new System.Windows.Forms.Button();
            this.BcancelCliente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TBnomCliente = new System.Windows.Forms.TextBox();
            this.TBapeCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TBdniCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TBtelCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TBdireCliente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.TBdireCliente);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.TBtelCliente);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.TBdniCliente);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TBapeCliente);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TBnomCliente);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BcancelCliente);
            this.panel1.Controls.Add(this.BguardarCliente);
            this.panel1.Location = new System.Drawing.Point(89, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(623, 384);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 460);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(902, 167);
            this.dataGridView1.TabIndex = 1;
            // 
            // BguardarCliente
            // 
            this.BguardarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BguardarCliente.Location = new System.Drawing.Point(183, 322);
            this.BguardarCliente.Name = "BguardarCliente";
            this.BguardarCliente.Size = new System.Drawing.Size(173, 39);
            this.BguardarCliente.TabIndex = 0;
            this.BguardarCliente.Text = "Guardar";
            this.BguardarCliente.UseVisualStyleBackColor = true;
            this.BguardarCliente.Click += new System.EventHandler(this.BguardarCliente_Click);
            // 
            // BcancelCliente
            // 
            this.BcancelCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BcancelCliente.Location = new System.Drawing.Point(468, 322);
            this.BcancelCliente.Name = "BcancelCliente";
            this.BcancelCliente.Size = new System.Drawing.Size(155, 39);
            this.BcancelCliente.TabIndex = 1;
            this.BcancelCliente.Text = "Cancelar";
            this.BcancelCliente.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(48, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // TBnomCliente
            // 
            this.TBnomCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TBnomCliente.Location = new System.Drawing.Point(183, 21);
            this.TBnomCliente.Name = "TBnomCliente";
            this.TBnomCliente.Size = new System.Drawing.Size(265, 35);
            this.TBnomCliente.TabIndex = 3;
            // 
            // TBapeCliente
            // 
            this.TBapeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TBapeCliente.Location = new System.Drawing.Point(183, 79);
            this.TBapeCliente.Name = "TBapeCliente";
            this.TBapeCliente.Size = new System.Drawing.Size(265, 35);
            this.TBapeCliente.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(48, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Apellido";
            // 
            // TBdniCliente
            // 
            this.TBdniCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TBdniCliente.Location = new System.Drawing.Point(183, 133);
            this.TBdniCliente.Name = "TBdniCliente";
            this.TBdniCliente.Size = new System.Drawing.Size(265, 35);
            this.TBdniCliente.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(48, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Telefono";
            // 
            // TBtelCliente
            // 
            this.TBtelCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TBtelCliente.Location = new System.Drawing.Point(183, 188);
            this.TBtelCliente.Name = "TBtelCliente";
            this.TBtelCliente.Size = new System.Drawing.Size(265, 35);
            this.TBtelCliente.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(48, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "DNI";
            // 
            // TBdireCliente
            // 
            this.TBdireCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TBdireCliente.Location = new System.Drawing.Point(183, 242);
            this.TBdireCliente.Name = "TBdireCliente";
            this.TBdireCliente.Size = new System.Drawing.Size(265, 35);
            this.TBdireCliente.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(48, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "Direccion";
            // 
            // FagregarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 592);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "FagregarCliente";
            this.Text = "Agregar Cliente";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox TBnomCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BcancelCliente;
        private System.Windows.Forms.Button BguardarCliente;
        private System.Windows.Forms.TextBox TBdireCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TBtelCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBdniCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBapeCliente;
        private System.Windows.Forms.Label label2;
    }
}