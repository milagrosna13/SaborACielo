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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ffactura));
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.Pcabecera = new System.Windows.Forms.Panel();
            this.TBtotal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TBmedio = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TBfactura = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TBvendedor = new System.Windows.Forms.TextBox();
            this.TBcliente = new System.Windows.Forms.TextBox();
            this.TBfecha = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Pdetalle = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Bimprimir = new System.Windows.Forms.Button();
            this.Pcabecera.SuspendLayout();
            this.Pdetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sabor \r\n    a\r\n Cielo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Fecha";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Cliente";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "Vendedor";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.Imprimir);
            // 
            // Pcabecera
            // 
            this.Pcabecera.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pcabecera.Controls.Add(this.TBtotal);
            this.Pcabecera.Controls.Add(this.label8);
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
            this.Pcabecera.Size = new System.Drawing.Size(1014, 185);
            this.Pcabecera.TabIndex = 9;
            // 
            // TBtotal
            // 
            this.TBtotal.Enabled = false;
            this.TBtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBtotal.Location = new System.Drawing.Point(861, 148);
            this.TBtotal.Name = "TBtotal";
            this.TBtotal.Size = new System.Drawing.Size(148, 30);
            this.TBtotal.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(764, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 25);
            this.label8.TabIndex = 15;
            this.label8.Text = "Total";
            // 
            // TBmedio
            // 
            this.TBmedio.Enabled = false;
            this.TBmedio.Location = new System.Drawing.Point(734, 86);
            this.TBmedio.Name = "TBmedio";
            this.TBmedio.Size = new System.Drawing.Size(246, 33);
            this.TBmedio.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(534, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Medio de pago";
            // 
            // TBfactura
            // 
            this.TBfactura.Enabled = false;
            this.TBfactura.Location = new System.Drawing.Point(734, 15);
            this.TBfactura.Name = "TBfactura";
            this.TBfactura.Size = new System.Drawing.Size(246, 33);
            this.TBfactura.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.label2.Location = new System.Drawing.Point(566, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Factura nro";
            // 
            // TBvendedor
            // 
            this.TBvendedor.Enabled = false;
            this.TBvendedor.Location = new System.Drawing.Point(153, 129);
            this.TBvendedor.Name = "TBvendedor";
            this.TBvendedor.Size = new System.Drawing.Size(246, 33);
            this.TBvendedor.TabIndex = 10;
            // 
            // TBcliente
            // 
            this.TBcliente.Enabled = false;
            this.TBcliente.Location = new System.Drawing.Point(153, 68);
            this.TBcliente.Name = "TBcliente";
            this.TBcliente.Size = new System.Drawing.Size(246, 33);
            this.TBcliente.TabIndex = 9;
            // 
            // TBfecha
            // 
            this.TBfecha.Enabled = false;
            this.TBfecha.Location = new System.Drawing.Point(153, 11);
            this.TBfecha.Name = "TBfecha";
            this.TBfecha.Size = new System.Drawing.Size(246, 33);
            this.TBfecha.TabIndex = 8;
            // 
            // textBox5
            // 
            this.textBox5.Enabled = false;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(454, 849);
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
            // Pdetalle
            // 
            this.Pdetalle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pdetalle.Controls.Add(this.dataGridView1);
            this.Pdetalle.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pdetalle.Location = new System.Drawing.Point(10, 336);
            this.Pdetalle.Name = "Pdetalle";
            this.Pdetalle.Size = new System.Drawing.Size(1026, 389);
            this.Pdetalle.TabIndex = 15;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeight = 34;
            this.dataGridView1.Location = new System.Drawing.Point(2, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(1018, 344);
            this.dataGridView1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(10, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 114);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // Bimprimir
            // 
            this.Bimprimir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Bimprimir.BackgroundImage")));
            this.Bimprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Bimprimir.Location = new System.Drawing.Point(931, 20);
            this.Bimprimir.Name = "Bimprimir";
            this.Bimprimir.Size = new System.Drawing.Size(72, 45);
            this.Bimprimir.TabIndex = 17;
            this.Bimprimir.UseVisualStyleBackColor = true;
            this.Bimprimir.Click += new System.EventHandler(this.Bimprimir_Click);
            // 
            // Ffactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1048, 749);
            this.Controls.Add(this.Bimprimir);
            this.Controls.Add(this.Pdetalle);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.Pcabecera);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Ffactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ffactura";
            this.Pcabecera.ResumeLayout(false);
            this.Pcabecera.PerformLayout();
            this.Pdetalle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
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
        private System.Windows.Forms.TextBox TBtotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Bimprimir;
    }
}