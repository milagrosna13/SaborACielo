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
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.Pcabecera = new System.Windows.Forms.Panel();
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
            this.TBtotal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
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
            this.label1.Location = new System.Drawing.Point(21, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sabor \r\n    a\r\n Cielo";
            // 
            // Bimprimir
            // 
            this.Bimprimir.Location = new System.Drawing.Point(618, 8);
            this.Bimprimir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Bimprimir.Name = "Bimprimir";
            this.Bimprimir.Size = new System.Drawing.Size(65, 29);
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
            this.pictureBox1.Location = new System.Drawing.Point(7, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 74);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Fecha";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 48);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Cliente";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 88);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Vendedor";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.Imprimir);
            // 
            // Pcabecera
            // 
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
            this.Pcabecera.Location = new System.Drawing.Point(7, 88);
            this.Pcabecera.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Pcabecera.Name = "Pcabecera";
            this.Pcabecera.Size = new System.Drawing.Size(676, 120);
            this.Pcabecera.TabIndex = 9;
            // 
            // TBmedio
            // 
            this.TBmedio.Enabled = false;
            this.TBmedio.Location = new System.Drawing.Point(489, 56);
            this.TBmedio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TBmedio.Name = "TBmedio";
            this.TBmedio.Size = new System.Drawing.Size(165, 24);
            this.TBmedio.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(356, 56);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Medio de pago";
            // 
            // TBfactura
            // 
            this.TBfactura.Enabled = false;
            this.TBfactura.Location = new System.Drawing.Point(489, 10);
            this.TBfactura.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TBfactura.Name = "TBfactura";
            this.TBfactura.Size = new System.Drawing.Size(165, 24);
            this.TBfactura.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(377, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Factura nro";
            // 
            // TBvendedor
            // 
            this.TBvendedor.Enabled = false;
            this.TBvendedor.Location = new System.Drawing.Point(102, 84);
            this.TBvendedor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TBvendedor.Name = "TBvendedor";
            this.TBvendedor.Size = new System.Drawing.Size(165, 24);
            this.TBvendedor.TabIndex = 10;
            // 
            // TBcliente
            // 
            this.TBcliente.Enabled = false;
            this.TBcliente.Location = new System.Drawing.Point(102, 44);
            this.TBcliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TBcliente.Name = "TBcliente";
            this.TBcliente.Size = new System.Drawing.Size(165, 24);
            this.TBcliente.TabIndex = 9;
            // 
            // TBfecha
            // 
            this.TBfecha.Enabled = false;
            this.TBfecha.Location = new System.Drawing.Point(102, 7);
            this.TBfecha.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TBfecha.Name = "TBfecha";
            this.TBfecha.Size = new System.Drawing.Size(165, 24);
            this.TBfecha.TabIndex = 8;
            // 
            // textBox5
            // 
            this.textBox5.Enabled = false;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(303, 552);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(165, 29);
            this.textBox5.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(179, 551);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "Total";
            // 
            // Pdetalle
            // 
            this.Pdetalle.Controls.Add(this.dataGridView1);
            this.Pdetalle.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pdetalle.Location = new System.Drawing.Point(7, 227);
            this.Pdetalle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Pdetalle.Name = "Pdetalle";
            this.Pdetalle.Size = new System.Drawing.Size(684, 302);
            this.Pdetalle.TabIndex = 15;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 12);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(667, 237);
            this.dataGridView1.TabIndex = 0;
            // 
            // TBtotal
            // 
            this.TBtotal.Enabled = false;
            this.TBtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBtotal.Location = new System.Drawing.Point(574, 96);
            this.TBtotal.Margin = new System.Windows.Forms.Padding(2);
            this.TBtotal.Name = "TBtotal";
            this.TBtotal.Size = new System.Drawing.Size(100, 22);
            this.TBtotal.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(509, 97);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 18);
            this.label8.TabIndex = 15;
            this.label8.Text = "Total";
            // 
            // Ffactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(699, 487);
            this.Controls.Add(this.Pdetalle);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.Pcabecera);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Bimprimir);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
    }
}