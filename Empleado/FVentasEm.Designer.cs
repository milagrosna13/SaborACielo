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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DGventas = new System.Windows.Forms.DataGridView();
            this.Lusuario = new System.Windows.Forms.Label();
            this.Pventas = new System.Windows.Forms.Panel();
            this.LdniEM = new System.Windows.Forms.Label();
            this.GBfiltroVenta = new System.Windows.Forms.GroupBox();
            this.CBmedios = new System.Windows.Forms.ComboBox();
            this.CBpago = new System.Windows.Forms.CheckBox();
            this.Cestado = new System.Windows.Forms.ComboBox();
            this.LnomE = new System.Windows.Forms.Label();
            this.TBnomE = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TBnomC = new System.Windows.Forms.TextBox();
            this.LdniE = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TBdniE = new System.Windows.Forms.TextBox();
            this.CBem = new System.Windows.Forms.CheckBox();
            this.CBestado = new System.Windows.Forms.CheckBox();
            this.TBdniC = new System.Windows.Forms.TextBox();
            this.CBcliente = new System.Windows.Forms.CheckBox();
            this.CBfecha = new System.Windows.Forms.CheckBox();
            this.DThasta = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.DTdesde = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DGventas)).BeginInit();
            this.Pventas.SuspendLayout();
            this.GBfiltroVenta.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGventas
            // 
            this.DGventas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGventas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGventas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGventas.Location = new System.Drawing.Point(48, 378);
            this.DGventas.Name = "DGventas";
            this.DGventas.RowHeadersWidth = 62;
            this.DGventas.RowTemplate.Height = 28;
            this.DGventas.Size = new System.Drawing.Size(1126, 360);
            this.DGventas.TabIndex = 0;
            this.DGventas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGventas_CellContentClick);
            // 
            // Lusuario
            // 
            this.Lusuario.AutoSize = true;
            this.Lusuario.Location = new System.Drawing.Point(39, 12);
            this.Lusuario.Name = "Lusuario";
            this.Lusuario.Size = new System.Drawing.Size(98, 27);
            this.Lusuario.TabIndex = 2;
            this.Lusuario.Text = "Empleado";
            // 
            // Pventas
            // 
            this.Pventas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pventas.BackColor = System.Drawing.Color.RosyBrown;
            this.Pventas.Controls.Add(this.LdniEM);
            this.Pventas.Controls.Add(this.GBfiltroVenta);
            this.Pventas.Controls.Add(this.Lusuario);
            this.Pventas.Font = new System.Drawing.Font("Script MT Bold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pventas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Pventas.Location = new System.Drawing.Point(48, 57);
            this.Pventas.Name = "Pventas";
            this.Pventas.Size = new System.Drawing.Size(1126, 304);
            this.Pventas.TabIndex = 3;
            // 
            // LdniEM
            // 
            this.LdniEM.AutoSize = true;
            this.LdniEM.Location = new System.Drawing.Point(155, 12);
            this.LdniEM.Name = "LdniEM";
            this.LdniEM.Size = new System.Drawing.Size(39, 27);
            this.LdniEM.TabIndex = 9;
            this.LdniEM.Text = "dni";
            // 
            // GBfiltroVenta
            // 
            this.GBfiltroVenta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GBfiltroVenta.Controls.Add(this.CBmedios);
            this.GBfiltroVenta.Controls.Add(this.CBpago);
            this.GBfiltroVenta.Controls.Add(this.Cestado);
            this.GBfiltroVenta.Controls.Add(this.LnomE);
            this.GBfiltroVenta.Controls.Add(this.TBnomE);
            this.GBfiltroVenta.Controls.Add(this.label7);
            this.GBfiltroVenta.Controls.Add(this.TBnomC);
            this.GBfiltroVenta.Controls.Add(this.LdniE);
            this.GBfiltroVenta.Controls.Add(this.label3);
            this.GBfiltroVenta.Controls.Add(this.TBdniE);
            this.GBfiltroVenta.Controls.Add(this.CBem);
            this.GBfiltroVenta.Controls.Add(this.CBestado);
            this.GBfiltroVenta.Controls.Add(this.TBdniC);
            this.GBfiltroVenta.Controls.Add(this.CBcliente);
            this.GBfiltroVenta.Controls.Add(this.CBfecha);
            this.GBfiltroVenta.Controls.Add(this.DThasta);
            this.GBfiltroVenta.Controls.Add(this.label5);
            this.GBfiltroVenta.Controls.Add(this.DTdesde);
            this.GBfiltroVenta.Controls.Add(this.label4);
            this.GBfiltroVenta.Location = new System.Drawing.Point(71, 42);
            this.GBfiltroVenta.Name = "GBfiltroVenta";
            this.GBfiltroVenta.Size = new System.Drawing.Size(970, 245);
            this.GBfiltroVenta.TabIndex = 8;
            this.GBfiltroVenta.TabStop = false;
            this.GBfiltroVenta.Text = "Filtrar por";
            // 
            // CBmedios
            // 
            this.CBmedios.Enabled = false;
            this.CBmedios.FormattingEnabled = true;
            this.CBmedios.Location = new System.Drawing.Point(551, 85);
            this.CBmedios.Name = "CBmedios";
            this.CBmedios.Size = new System.Drawing.Size(265, 35);
            this.CBmedios.TabIndex = 26;
            this.CBmedios.SelectedIndexChanged += new System.EventHandler(this.CBmedios_SelectedIndexChanged);
            // 
            // CBpago
            // 
            this.CBpago.AutoSize = true;
            this.CBpago.Location = new System.Drawing.Point(376, 89);
            this.CBpago.Name = "CBpago";
            this.CBpago.Size = new System.Drawing.Size(169, 31);
            this.CBpago.TabIndex = 25;
            this.CBpago.Text = "Medio de pago";
            this.CBpago.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CBpago.UseVisualStyleBackColor = true;
            this.CBpago.CheckedChanged += new System.EventHandler(this.CBpago_CheckedChanged);
            // 
            // Cestado
            // 
            this.Cestado.Enabled = false;
            this.Cestado.FormattingEnabled = true;
            this.Cestado.Location = new System.Drawing.Point(148, 87);
            this.Cestado.Name = "Cestado";
            this.Cestado.Size = new System.Drawing.Size(121, 35);
            this.Cestado.TabIndex = 24;
            this.Cestado.SelectedIndexChanged += new System.EventHandler(this.Cestado_SelectedIndexChanged);
            // 
            // LnomE
            // 
            this.LnomE.AutoSize = true;
            this.LnomE.Location = new System.Drawing.Point(526, 201);
            this.LnomE.Name = "LnomE";
            this.LnomE.Size = new System.Drawing.Size(83, 27);
            this.LnomE.TabIndex = 23;
            this.LnomE.Text = "Nombre";
            // 
            // TBnomE
            // 
            this.TBnomE.Enabled = false;
            this.TBnomE.Location = new System.Drawing.Point(615, 194);
            this.TBnomE.Name = "TBnomE";
            this.TBnomE.Size = new System.Drawing.Size(268, 34);
            this.TBnomE.TabIndex = 22;
            this.TBnomE.TextChanged += new System.EventHandler(this.TBnomE_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(529, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 27);
            this.label7.TabIndex = 21;
            this.label7.Text = "Nombre";
            // 
            // TBnomC
            // 
            this.TBnomC.Enabled = false;
            this.TBnomC.Location = new System.Drawing.Point(615, 141);
            this.TBnomC.Name = "TBnomC";
            this.TBnomC.Size = new System.Drawing.Size(268, 34);
            this.TBnomC.TabIndex = 20;
            this.TBnomC.TextChanged += new System.EventHandler(this.TBnomC_TextChanged);
            // 
            // LdniE
            // 
            this.LdniE.AutoSize = true;
            this.LdniE.Location = new System.Drawing.Point(169, 201);
            this.LdniE.Name = "LdniE";
            this.LdniE.Size = new System.Drawing.Size(45, 27);
            this.LdniE.TabIndex = 19;
            this.LdniE.Text = "Dni";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 27);
            this.label3.TabIndex = 18;
            this.label3.Text = "Dni";
            // 
            // TBdniE
            // 
            this.TBdniE.Enabled = false;
            this.TBdniE.Location = new System.Drawing.Point(240, 194);
            this.TBdniE.Name = "TBdniE";
            this.TBdniE.Size = new System.Drawing.Size(268, 34);
            this.TBdniE.TabIndex = 17;
            this.TBdniE.TextChanged += new System.EventHandler(this.Tbem_TextChanged);
            this.TBdniE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBdniE_KeyPress);
            // 
            // CBem
            // 
            this.CBem.AutoSize = true;
            this.CBem.Location = new System.Drawing.Point(32, 201);
            this.CBem.Name = "CBem";
            this.CBem.Size = new System.Drawing.Size(124, 31);
            this.CBem.TabIndex = 16;
            this.CBem.Text = "Empleado";
            this.CBem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CBem.UseVisualStyleBackColor = true;
            this.CBem.CheckedChanged += new System.EventHandler(this.CBem_CheckedChanged);
            // 
            // CBestado
            // 
            this.CBestado.AutoSize = true;
            this.CBestado.Location = new System.Drawing.Point(33, 89);
            this.CBestado.Name = "CBestado";
            this.CBestado.Size = new System.Drawing.Size(96, 31);
            this.CBestado.TabIndex = 15;
            this.CBestado.Text = "Estado";
            this.CBestado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CBestado.UseVisualStyleBackColor = true;
            this.CBestado.CheckedChanged += new System.EventHandler(this.CBestado_CheckedChanged);
            // 
            // TBdniC
            // 
            this.TBdniC.Enabled = false;
            this.TBdniC.Location = new System.Drawing.Point(240, 141);
            this.TBdniC.Name = "TBdniC";
            this.TBdniC.Size = new System.Drawing.Size(268, 34);
            this.TBdniC.TabIndex = 14;
            this.TBdniC.TextChanged += new System.EventHandler(this.TBdniC_TextChanged);
            this.TBdniC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Fcliente_KeyPress);
            // 
            // CBcliente
            // 
            this.CBcliente.AutoSize = true;
            this.CBcliente.Location = new System.Drawing.Point(32, 141);
            this.CBcliente.Name = "CBcliente";
            this.CBcliente.Size = new System.Drawing.Size(95, 31);
            this.CBcliente.TabIndex = 9;
            this.CBcliente.Text = "Cliente";
            this.CBcliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CBcliente.UseVisualStyleBackColor = true;
            this.CBcliente.CheckedChanged += new System.EventHandler(this.CBcliente_CheckedChanged);
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
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(497, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 38);
            this.label1.TabIndex = 9;
            this.label1.Text = "Lista de ventas";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Sienna;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1225, 53);
            this.panel1.TabIndex = 11;
            // 
            // FVentasEm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SaborAcielo.Properties.Resources.fondoSACinicio;
            this.ClientSize = new System.Drawing.Size(1225, 773);
            this.Controls.Add(this.Pventas);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DGventas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FVentasEm";
            this.Text = "FlistarVentas";
            ((System.ComponentModel.ISupportInitialize)(this.DGventas)).EndInit();
            this.Pventas.ResumeLayout(false);
            this.Pventas.PerformLayout();
            this.GBfiltroVenta.ResumeLayout(false);
            this.GBfiltroVenta.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGventas;
        private System.Windows.Forms.Label Lusuario;
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
        private System.Windows.Forms.CheckBox CBestado;
        private System.Windows.Forms.TextBox TBdniE;
        private System.Windows.Forms.CheckBox CBem;
        private System.Windows.Forms.Label LnomE;
        private System.Windows.Forms.TextBox TBnomE;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TBnomC;
        private System.Windows.Forms.Label LdniE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Cestado;
        private System.Windows.Forms.Label LdniEM;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox CBmedios;
        private System.Windows.Forms.CheckBox CBpago;
    }
}