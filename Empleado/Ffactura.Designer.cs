namespace SaborAcielo.Empleado
{
    partial class Ffactura
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
            this.label1 = new System.Windows.Forms.Label();
            this.Bimprimir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Bpdf = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.Pcabecera = new System.Windows.Forms.Panel();
            this.TBfecha = new System.Windows.Forms.TextBox();
            this.TBcliente = new System.Windows.Forms.TextBox();
            this.TBvendedor = new System.Windows.Forms.TextBox();
            this.TBfactura = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TBmedio = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Pdetalle = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Pcabecera.SuspendLayout();
            this.Pdetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sabor \r\n    a\r\n Cielo";
            // 
            // Bimprimir
            // 
            this.Bimprimir.Location = new System.Drawing.Point(927, 12);
            this.Bimprimir.Name = "Bimprimir";
            this.Bimprimir.Size = new System.Drawing.Size(98, 45);
            this.Bimprimir.TabIndex = 3;
            this.Bimprimir.Text = "Imprimir";
            this.Bimprimir.UseVisualStyleBackColor = true;
            this.Bimprimir.Click += new System.EventHandler(this.Bimprimir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::SaborAcielo.Properties.Resources.saboracielo2;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(10, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 114);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 27);
            this.label4.TabIndex = 5;
            this.label4.Text = "Fecha";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 27);
            this.label5.TabIndex = 6;
            this.label5.Text = "Cliente";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 27);
            this.label6.TabIndex = 7;
            this.label6.Text = "Vendedor";
            // 
            // Bpdf
            // 
            this.Bpdf.Location = new System.Drawing.Point(927, 63);
            this.Bpdf.Name = "Bpdf";
            this.Bpdf.Size = new System.Drawing.Size(98, 45);
            this.Bpdf.TabIndex = 8;
            this.Bpdf.Text = "PDF";
            this.Bpdf.UseVisualStyleBackColor = true;
            this.Bpdf.Click += new System.EventHandler(this.Bpdf_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.Imprimir);
            // 
            // Pcabecera
            // 
            this.Pcabecera.Controls.Add(this.TBmedio);
            this.Pcabecera.Controls.Add(this.label7);
            this.Pcabecera.Controls.Add(this.TBfactura);
            this.Pcabecera.Controls.Add(this.label2);
            this.Pcabecera.Controls.Add(this.TBvendedor);
            this.Pcabecera.Controls.Add(this.TBcliente);
            this.Pcabecera.Controls.Add(this.TBfecha);
            this.Pcabecera.Controls.Add(this.label6);
            this.Pcabecera.Controls.Add(this.label4);
            this.Pcabecera.Controls.Add(this.label5);
            this.Pcabecera.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pcabecera.Location = new System.Drawing.Point(10, 135);
            this.Pcabecera.Name = "Pcabecera";
            this.Pcabecera.Size = new System.Drawing.Size(782, 185);
            this.Pcabecera.TabIndex = 9;
            // 
            // TBfecha
            // 
            this.TBfecha.Enabled = false;
            this.TBfecha.Location = new System.Drawing.Point(90, 12);
            this.TBfecha.Name = "TBfecha";
            this.TBfecha.Size = new System.Drawing.Size(246, 33);
            this.TBfecha.TabIndex = 8;
            // 
            // TBcliente
            // 
            this.TBcliente.Enabled = false;
            this.TBcliente.Location = new System.Drawing.Point(90, 65);
            this.TBcliente.Name = "TBcliente";
            this.TBcliente.Size = new System.Drawing.Size(246, 33);
            this.TBcliente.TabIndex = 9;
            // 
            // TBvendedor
            // 
            this.TBvendedor.Enabled = false;
            this.TBvendedor.Location = new System.Drawing.Point(120, 130);
            this.TBvendedor.Name = "TBvendedor";
            this.TBvendedor.Size = new System.Drawing.Size(246, 33);
            this.TBvendedor.TabIndex = 10;
            // 
            // TBfactura
            // 
            this.TBfactura.Enabled = false;
            this.TBfactura.Location = new System.Drawing.Point(526, 15);
            this.TBfactura.Name = "TBfactura";
            this.TBfactura.Size = new System.Drawing.Size(253, 33);
            this.TBfactura.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(399, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 27);
            this.label2.TabIndex = 11;
            this.label2.Text = "Factura nro";
            // 
            // textBox5
            // 
            this.textBox5.Enabled = false;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(455, 849);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(246, 39);
            this.textBox5.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(268, 848);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 32);
            this.label3.TabIndex = 13;
            this.label3.Text = "Total";
            // 
            // TBmedio
            // 
            this.TBmedio.Enabled = false;
            this.TBmedio.Location = new System.Drawing.Point(529, 65);
            this.TBmedio.Name = "TBmedio";
            this.TBmedio.Size = new System.Drawing.Size(246, 33);
            this.TBmedio.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(363, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 27);
            this.label7.TabIndex = 13;
            this.label7.Text = "Medio de pago";
            // 
            // Pdetalle
            // 
            this.Pdetalle.Controls.Add(this.dataGridView1);
            this.Pdetalle.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pdetalle.Location = new System.Drawing.Point(10, 350);
            this.Pdetalle.Name = "Pdetalle";
            this.Pdetalle.Size = new System.Drawing.Size(1026, 464);
            this.Pdetalle.TabIndex = 15;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1000, 364);
            this.dataGridView1.TabIndex = 0;
            // 
            // Ffactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1048, 896);
            this.Controls.Add(this.Pdetalle);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.Pcabecera);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Bpdf);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Bimprimir);
            this.Name = "Ffactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ffactura";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Pcabecera.ResumeLayout(false);
            this.Pcabecera.PerformLayout();
            this.Pdetalle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Bimprimir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Bpdf;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Panel Pcabecera;
        private System.Windows.Forms.TextBox TBfactura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBvendedor;
        private System.Windows.Forms.TextBox TBcliente;
        private System.Windows.Forms.TextBox TBfecha;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBmedio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel Pdetalle;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}