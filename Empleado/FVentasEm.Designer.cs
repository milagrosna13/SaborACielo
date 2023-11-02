namespace SaborAcielo
{
    partial class FVentasEm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DGventas = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.Pventas = new System.Windows.Forms.Panel();
            this.GBfiltroVenta = new System.Windows.Forms.GroupBox();
            this.TBnomE = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TBnomC = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TBdniE = new System.Windows.Forms.TextBox();
            this.CBem = new System.Windows.Forms.CheckBox();
            this.CBalta = new System.Windows.Forms.CheckBox();
            this.TBdniC = new System.Windows.Forms.TextBox();
            this.CBcliente = new System.Windows.Forms.CheckBox();
            this.CBfecha = new System.Windows.Forms.CheckBox();
            this.DThasta = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.DTdesde = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DGdetalle = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGventas)).BeginInit();
            this.Pventas.SuspendLayout();
            this.GBfiltroVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGdetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // DGventas
            // 
            this.DGventas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DGventas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGventas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DGventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGventas.Location = new System.Drawing.Point(1, 332);
            this.DGventas.Name = "DGventas";
            this.DGventas.RowHeadersWidth = 62;
            this.DGventas.RowTemplate.Height = 28;
            this.DGventas.Size = new System.Drawing.Size(669, 429);
            this.DGventas.TabIndex = 0;
            this.DGventas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGventas_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Empleado";
            // 
            // Pventas
            // 
            this.Pventas.BackColor = System.Drawing.Color.RosyBrown;
            this.Pventas.Controls.Add(this.GBfiltroVenta);
            this.Pventas.Controls.Add(this.label2);
            this.Pventas.Font = new System.Drawing.Font("Script MT Bold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pventas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Pventas.Location = new System.Drawing.Point(86, 50);
            this.Pventas.Name = "Pventas";
            this.Pventas.Size = new System.Drawing.Size(993, 246);
            this.Pventas.TabIndex = 3;
            // 
            // GBfiltroVenta
            // 
            this.GBfiltroVenta.Controls.Add(this.TBnomE);
            this.GBfiltroVenta.Controls.Add(this.textBox2);
            this.GBfiltroVenta.Controls.Add(this.label7);
            this.GBfiltroVenta.Controls.Add(this.TBnomC);
            this.GBfiltroVenta.Controls.Add(this.label6);
            this.GBfiltroVenta.Controls.Add(this.label3);
            this.GBfiltroVenta.Controls.Add(this.TBdniE);
            this.GBfiltroVenta.Controls.Add(this.CBem);
            this.GBfiltroVenta.Controls.Add(this.CBalta);
            this.GBfiltroVenta.Controls.Add(this.TBdniC);
            this.GBfiltroVenta.Controls.Add(this.CBcliente);
            this.GBfiltroVenta.Controls.Add(this.CBfecha);
            this.GBfiltroVenta.Controls.Add(this.DThasta);
            this.GBfiltroVenta.Controls.Add(this.label5);
            this.GBfiltroVenta.Controls.Add(this.DTdesde);
            this.GBfiltroVenta.Controls.Add(this.label4);
            this.GBfiltroVenta.Location = new System.Drawing.Point(35, 42);
            this.GBfiltroVenta.Name = "GBfiltroVenta";
            this.GBfiltroVenta.Size = new System.Drawing.Size(908, 198);
            this.GBfiltroVenta.TabIndex = 8;
            this.GBfiltroVenta.TabStop = false;
            this.GBfiltroVenta.Text = "Filtrar por";
            // 
            // TBnomE
            // 
            this.TBnomE.AutoSize = true;
            this.TBnomE.Location = new System.Drawing.Point(506, 148);
            this.TBnomE.Name = "TBnomE";
            this.TBnomE.Size = new System.Drawing.Size(83, 27);
            this.TBnomE.TabIndex = 23;
            this.TBnomE.Text = "Nombre";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(589, 145);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(268, 34);
            this.textBox2.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(503, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 27);
            this.label7.TabIndex = 21;
            this.label7.Text = "Nombre";
            // 
            // TBnomC
            // 
            this.TBnomC.Location = new System.Drawing.Point(589, 88);
            this.TBnomC.Name = "TBnomC";
            this.TBnomC.Size = new System.Drawing.Size(268, 34);
            this.TBnomC.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(143, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 27);
            this.label6.TabIndex = 19;
            this.label6.Text = "Dni";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 27);
            this.label3.TabIndex = 18;
            this.label3.Text = "Dni";
            // 
            // TBdniE
            // 
            this.TBdniE.Location = new System.Drawing.Point(214, 141);
            this.TBdniE.Name = "TBdniE";
            this.TBdniE.Size = new System.Drawing.Size(268, 34);
            this.TBdniE.TabIndex = 17;
            this.TBdniE.TextChanged += new System.EventHandler(this.Tbem_TextChanged);
            this.TBdniE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBdniE_KeyPress);
            // 
            // CBem
            // 
            this.CBem.AutoSize = true;
            this.CBem.Location = new System.Drawing.Point(6, 141);
            this.CBem.Name = "CBem";
            this.CBem.Size = new System.Drawing.Size(124, 31);
            this.CBem.TabIndex = 16;
            this.CBem.Text = "Empleado";
            this.CBem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CBem.UseVisualStyleBackColor = true;
            // 
            // CBalta
            // 
            this.CBalta.AutoSize = true;
            this.CBalta.Location = new System.Drawing.Point(761, 32);
            this.CBalta.Name = "CBalta";
            this.CBalta.Size = new System.Drawing.Size(96, 31);
            this.CBalta.TabIndex = 15;
            this.CBalta.Text = "Estado";
            this.CBalta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CBalta.UseVisualStyleBackColor = true;
            // 
            // TBdniC
            // 
            this.TBdniC.Location = new System.Drawing.Point(214, 88);
            this.TBdniC.Name = "TBdniC";
            this.TBdniC.Size = new System.Drawing.Size(268, 34);
            this.TBdniC.TabIndex = 14;
            this.TBdniC.TextChanged += new System.EventHandler(this.TBdniC_TextChanged);
            this.TBdniC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Fcliente_KeyPress);
            // 
            // CBcliente
            // 
            this.CBcliente.AutoSize = true;
            this.CBcliente.Location = new System.Drawing.Point(6, 88);
            this.CBcliente.Name = "CBcliente";
            this.CBcliente.Size = new System.Drawing.Size(95, 31);
            this.CBcliente.TabIndex = 9;
            this.CBcliente.Text = "Cliente";
            this.CBcliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CBcliente.UseVisualStyleBackColor = true;
            // 
            // CBfecha
            // 
            this.CBfecha.AutoSize = true;
            this.CBfecha.Location = new System.Drawing.Point(32, 34);
            this.CBfecha.Name = "CBfecha";
            this.CBfecha.Size = new System.Drawing.Size(89, 31);
            this.CBfecha.TabIndex = 8;
            this.CBfecha.Text = "Fecha";
            this.CBfecha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CBfecha.UseVisualStyleBackColor = true;
            this.CBfecha.CheckedChanged += new System.EventHandler(this.CBfecha_CheckedChanged);
            // 
            // DThasta
            // 
            this.DThasta.Enabled = false;
            this.DThasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DThasta.Location = new System.Drawing.Point(466, 32);
            this.DThasta.MaxDate = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            this.DThasta.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.DThasta.Name = "DThasta";
            this.DThasta.Size = new System.Drawing.Size(154, 34);
            this.DThasta.TabIndex = 6;
            this.DThasta.Value = new System.DateTime(2023, 10, 29, 0, 0, 0, 0);
            this.DThasta.ValueChanged += new System.EventHandler(this.DThasta_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(392, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 27);
            this.label5.TabIndex = 7;
            this.label5.Text = "Hasta";
            // 
            // DTdesde
            // 
            this.DTdesde.Enabled = false;
            this.DTdesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTdesde.Location = new System.Drawing.Point(235, 32);
            this.DTdesde.MaxDate = new System.DateTime(2023, 9, 14, 20, 31, 59, 0);
            this.DTdesde.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.DTdesde.Name = "DTdesde";
            this.DTdesde.Size = new System.Drawing.Size(151, 34);
            this.DTdesde.TabIndex = 4;
            this.DTdesde.Value = new System.DateTime(2023, 9, 14, 0, 0, 0, 0);
            this.DTdesde.ValueChanged += new System.EventHandler(this.DTdesde_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(164, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 27);
            this.label4.TabIndex = 5;
            this.label4.Text = "Desde";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(461, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 38);
            this.label1.TabIndex = 9;
            this.label1.Text = "Lista de ventas";
            // 
            // DGdetalle
            // 
            this.DGdetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DGdetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGdetalle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DGdetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGdetalle.Location = new System.Drawing.Point(666, 332);
            this.DGdetalle.Name = "DGdetalle";
            this.DGdetalle.RowHeadersWidth = 62;
            this.DGdetalle.RowTemplate.Height = 28;
            this.DGdetalle.Size = new System.Drawing.Size(557, 429);
            this.DGdetalle.TabIndex = 10;
            // 
            // FVentasEm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SaborAcielo.Properties.Resources.fondoSACinicio;
            this.ClientSize = new System.Drawing.Size(1225, 773);
            this.Controls.Add(this.DGdetalle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Pventas);
            this.Controls.Add(this.DGventas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FVentasEm";
            this.Text = "FlistarVentas";
            ((System.ComponentModel.ISupportInitialize)(this.DGventas)).EndInit();
            this.Pventas.ResumeLayout(false);
            this.Pventas.PerformLayout();
            this.GBfiltroVenta.ResumeLayout(false);
            this.GBfiltroVenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGdetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGventas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel Pventas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker DThasta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DTdesde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GBfiltroVenta;
        private System.Windows.Forms.CheckBox CBfecha;
        private System.Windows.Forms.CheckBox CBcliente;
        private System.Windows.Forms.TextBox TBdniC;
        private System.Windows.Forms.CheckBox CBalta;
        private System.Windows.Forms.TextBox TBdniE;
        private System.Windows.Forms.CheckBox CBem;
        private System.Windows.Forms.Label TBnomE;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TBnomC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DGdetalle;
    }
}