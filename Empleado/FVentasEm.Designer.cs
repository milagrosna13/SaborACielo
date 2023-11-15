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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CBtodos = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGventas)).BeginInit();
            this.Pventas.SuspendLayout();
            this.GBfiltroVenta.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGventas
            // 
            this.DGventas.AllowUserToAddRows = false;
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
            this.DGventas.Location = new System.Drawing.Point(48, 355);
            this.DGventas.Name = "DGventas";
            this.DGventas.RowHeadersWidth = 62;
            this.DGventas.RowTemplate.Height = 28;
            this.DGventas.Size = new System.Drawing.Size(1126, 401);
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
            this.Pventas.Size = new System.Drawing.Size(1126, 277);
            this.Pventas.TabIndex = 3;
            // 
            // LdniEM
            // 
            this.LdniEM.AutoSize = true;
            this.LdniEM.Location = new System.Drawing.Point(154, 12);
            this.LdniEM.Name = "LdniEM";
            this.LdniEM.Size = new System.Drawing.Size(39, 27);
            this.LdniEM.TabIndex = 9;
            this.LdniEM.Text = "dni";
            // 
            // GBfiltroVenta
            // 
            this.GBfiltroVenta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GBfiltroVenta.Controls.Add(this.CBtodos);
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
            this.GBfiltroVenta.Location = new System.Drawing.Point(70, 42);
            this.GBfiltroVenta.Name = "GBfiltroVenta";
            this.GBfiltroVenta.Size = new System.Drawing.Size(970, 232);
            this.GBfiltroVenta.TabIndex = 8;
            this.GBfiltroVenta.TabStop = false;
            this.GBfiltroVenta.Text = "Filtrar por";
            // 
            // CBmedios
            // 
            this.CBmedios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBmedios.Enabled = false;
            this.CBmedios.FormattingEnabled = true;
            this.CBmedios.Location = new System.Drawing.Point(547, 36);
            this.CBmedios.Name = "CBmedios";
            this.CBmedios.Size = new System.Drawing.Size(238, 35);
            this.CBmedios.TabIndex = 26;
            this.CBmedios.SelectedIndexChanged += new System.EventHandler(this.CBmedios_SelectedIndexChanged);
            // 
            // CBpago
            // 
            this.CBpago.AutoSize = true;
            this.CBpago.Location = new System.Drawing.Point(373, 40);
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
            this.Cestado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cestado.Enabled = false;
            this.Cestado.FormattingEnabled = true;
            this.Cestado.Location = new System.Drawing.Point(145, 39);
            this.Cestado.Name = "Cestado";
            this.Cestado.Size = new System.Drawing.Size(147, 35);
            this.Cestado.TabIndex = 24;
            this.Cestado.SelectedIndexChanged += new System.EventHandler(this.Cestado_SelectedIndexChanged);
            // 
            // LnomE
            // 
            this.LnomE.AutoSize = true;
            this.LnomE.Location = new System.Drawing.Point(523, 153);
            this.LnomE.Name = "LnomE";
            this.LnomE.Size = new System.Drawing.Size(83, 27);
            this.LnomE.TabIndex = 23;
            this.LnomE.Text = "Nombre";
            // 
            // TBnomE
            // 
            this.TBnomE.Enabled = false;
            this.TBnomE.Location = new System.Drawing.Point(612, 145);
            this.TBnomE.Name = "TBnomE";
            this.TBnomE.Size = new System.Drawing.Size(268, 34);
            this.TBnomE.TabIndex = 22;
            this.TBnomE.TextChanged += new System.EventHandler(this.TBnomE_TextChanged);
            this.TBnomE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBnomE_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(527, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 27);
            this.label7.TabIndex = 21;
            this.label7.Text = "Nombre";
            // 
            // TBnomC
            // 
            this.TBnomC.Enabled = false;
            this.TBnomC.Location = new System.Drawing.Point(612, 93);
            this.TBnomC.Name = "TBnomC";
            this.TBnomC.Size = new System.Drawing.Size(268, 34);
            this.TBnomC.TabIndex = 20;
            this.TBnomC.TextChanged += new System.EventHandler(this.TBnomC_TextChanged);
            this.TBnomC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBnomC_KeyPress);
            // 
            // LdniE
            // 
            this.LdniE.AutoSize = true;
            this.LdniE.Location = new System.Drawing.Point(167, 153);
            this.LdniE.Name = "LdniE";
            this.LdniE.Size = new System.Drawing.Size(45, 27);
            this.LdniE.TabIndex = 19;
            this.LdniE.Text = "Dni";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(167, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 27);
            this.label3.TabIndex = 18;
            this.label3.Text = "Dni";
            // 
            // TBdniE
            // 
            this.TBdniE.Enabled = false;
            this.TBdniE.Location = new System.Drawing.Point(237, 145);
            this.TBdniE.Name = "TBdniE";
            this.TBdniE.Size = new System.Drawing.Size(268, 34);
            this.TBdniE.TabIndex = 17;
            this.TBdniE.TextChanged += new System.EventHandler(this.Tbem_TextChanged);
            this.TBdniE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBdniE_KeyPress);
            // 
            // CBem
            // 
            this.CBem.AutoSize = true;
            this.CBem.Location = new System.Drawing.Point(29, 153);
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
            this.CBestado.Location = new System.Drawing.Point(30, 40);
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
            this.TBdniC.Location = new System.Drawing.Point(237, 93);
            this.TBdniC.Name = "TBdniC";
            this.TBdniC.Size = new System.Drawing.Size(268, 34);
            this.TBdniC.TabIndex = 14;
            this.TBdniC.TextChanged += new System.EventHandler(this.TBdniC_TextChanged);
            this.TBdniC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Fcliente_KeyPress);
            // 
            // CBcliente
            // 
            this.CBcliente.AutoSize = true;
            this.CBcliente.Location = new System.Drawing.Point(29, 93);
            this.CBcliente.Name = "CBcliente";
            this.CBcliente.Size = new System.Drawing.Size(95, 31);
            this.CBcliente.TabIndex = 9;
            this.CBcliente.Text = "Cliente";
            this.CBcliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CBcliente.UseVisualStyleBackColor = true;
            this.CBcliente.CheckedChanged += new System.EventHandler(this.CBcliente_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(496, 3);
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
            this.panel1.Size = new System.Drawing.Size(1226, 52);
            this.panel1.TabIndex = 11;
            // 
            // CBtodos
            // 
            this.CBtodos.AutoSize = true;
            this.CBtodos.Location = new System.Drawing.Point(748, 195);
            this.CBtodos.Name = "CBtodos";
            this.CBtodos.Size = new System.Drawing.Size(188, 31);
            this.CBtodos.TabIndex = 27;
            this.CBtodos.Text = "Todas las ventas";
            this.CBtodos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CBtodos.UseVisualStyleBackColor = true;
            this.CBtodos.CheckedChanged += new System.EventHandler(this.CBtodos_CheckedChanged);
            // 
            // FVentasEm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SaborAcielo.Properties.Resources.fondoSACinicio;
            this.ClientSize = new System.Drawing.Size(1226, 772);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GBfiltroVenta;
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
        private System.Windows.Forms.CheckBox CBtodos;
    }
}