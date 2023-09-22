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
            this.DGventas = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.Pventas = new System.Windows.Forms.Panel();
            this.GBfiltroVenta = new System.Windows.Forms.GroupBox();
            this.Ccliente = new System.Windows.Forms.ComboBox();
            this.CBcliente = new System.Windows.Forms.CheckBox();
            this.CBfecha = new System.Windows.Forms.CheckBox();
            this.DThasta = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.DTdesde = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Lempleado = new System.Windows.Forms.Label();
            this.id_venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dni_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGventas)).BeginInit();
            this.Pventas.SuspendLayout();
            this.GBfiltroVenta.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGventas
            // 
            this.DGventas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGventas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_venta,
            this.dni_cliente,
            this.total});
            this.DGventas.Location = new System.Drawing.Point(27, 415);
            this.DGventas.Name = "DGventas";
            this.DGventas.RowHeadersWidth = 62;
            this.DGventas.RowTemplate.Height = 28;
            this.DGventas.Size = new System.Drawing.Size(1121, 346);
            this.DGventas.TabIndex = 0;
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
            this.Pventas.Controls.Add(this.Lempleado);
            this.Pventas.Controls.Add(this.GBfiltroVenta);
            this.Pventas.Controls.Add(this.label2);
            this.Pventas.Font = new System.Drawing.Font("Script MT Bold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pventas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Pventas.Location = new System.Drawing.Point(84, 50);
            this.Pventas.Name = "Pventas";
            this.Pventas.Size = new System.Drawing.Size(851, 250);
            this.Pventas.TabIndex = 3;
            // 
            // GBfiltroVenta
            // 
            this.GBfiltroVenta.Controls.Add(this.Ccliente);
            this.GBfiltroVenta.Controls.Add(this.CBcliente);
            this.GBfiltroVenta.Controls.Add(this.CBfecha);
            this.GBfiltroVenta.Controls.Add(this.DThasta);
            this.GBfiltroVenta.Controls.Add(this.label5);
            this.GBfiltroVenta.Controls.Add(this.DTdesde);
            this.GBfiltroVenta.Controls.Add(this.label4);
            this.GBfiltroVenta.Location = new System.Drawing.Point(35, 63);
            this.GBfiltroVenta.Name = "GBfiltroVenta";
            this.GBfiltroVenta.Size = new System.Drawing.Size(776, 162);
            this.GBfiltroVenta.TabIndex = 8;
            this.GBfiltroVenta.TabStop = false;
            this.GBfiltroVenta.Text = "Filtrar por";
            // 
            // Ccliente
            // 
            this.Ccliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ccliente.FormattingEnabled = true;
            this.Ccliente.Location = new System.Drawing.Point(223, 104);
            this.Ccliente.Name = "Ccliente";
            this.Ccliente.Size = new System.Drawing.Size(280, 34);
            this.Ccliente.TabIndex = 10;
            // 
            // CBcliente
            // 
            this.CBcliente.AutoSize = true;
            this.CBcliente.Location = new System.Drawing.Point(28, 104);
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
            this.CBfecha.Location = new System.Drawing.Point(28, 39);
            this.CBfecha.Name = "CBfecha";
            this.CBfecha.Size = new System.Drawing.Size(89, 31);
            this.CBfecha.TabIndex = 8;
            this.CBfecha.Text = "Fecha";
            this.CBfecha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CBfecha.UseVisualStyleBackColor = true;
            // 
            // DThasta
            // 
            this.DThasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DThasta.Location = new System.Drawing.Point(547, 36);
            this.DThasta.MaxDate = new System.DateTime(2023, 9, 14, 0, 0, 0, 0);
            this.DThasta.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.DThasta.Name = "DThasta";
            this.DThasta.Size = new System.Drawing.Size(154, 34);
            this.DThasta.TabIndex = 6;
            this.DThasta.Value = new System.DateTime(2023, 9, 14, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(473, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 27);
            this.label5.TabIndex = 7;
            this.label5.Text = "Hasta";
            // 
            // DTdesde
            // 
            this.DTdesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTdesde.Location = new System.Drawing.Point(289, 36);
            this.DTdesde.MaxDate = new System.DateTime(2023, 9, 14, 20, 31, 59, 0);
            this.DTdesde.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.DTdesde.Name = "DTdesde";
            this.DTdesde.Size = new System.Drawing.Size(138, 34);
            this.DTdesde.TabIndex = 4;
            this.DTdesde.Value = new System.DateTime(2023, 9, 14, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(218, 36);
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
            this.label1.Location = new System.Drawing.Point(369, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 38);
            this.label1.TabIndex = 9;
            this.label1.Text = "Lista de ventas";
            // 
            // Lempleado
            // 
            this.Lempleado.AutoSize = true;
            this.Lempleado.Location = new System.Drawing.Point(193, 12);
            this.Lempleado.Name = "Lempleado";
            this.Lempleado.Size = new System.Drawing.Size(66, 27);
            this.Lempleado.TabIndex = 9;
            this.Lempleado.Text = "label3";
            // 
            // id_venta
            // 
            this.id_venta.HeaderText = "Venta nr";
            this.id_venta.MinimumWidth = 8;
            this.id_venta.Name = "id_venta";
            this.id_venta.Width = 150;
            // 
            // dni_cliente
            // 
            this.dni_cliente.HeaderText = "Cliente";
            this.dni_cliente.MinimumWidth = 8;
            this.dni_cliente.Name = "dni_cliente";
            this.dni_cliente.Width = 150;
            // 
            // total
            // 
            this.total.HeaderText = "Total";
            this.total.MinimumWidth = 8;
            this.total.Name = "total";
            this.total.Width = 150;
            // 
            // FlistarVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SaborAcielo.Properties.Resources.fondoSACinicio;
            this.ClientSize = new System.Drawing.Size(1225, 773);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Pventas);
            this.Controls.Add(this.DGventas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FlistarVentas";
            this.Text = "FlistarVentas";
            ((System.ComponentModel.ISupportInitialize)(this.DGventas)).EndInit();
            this.Pventas.ResumeLayout(false);
            this.Pventas.PerformLayout();
            this.GBfiltroVenta.ResumeLayout(false);
            this.GBfiltroVenta.PerformLayout();
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
        private System.Windows.Forms.ComboBox Ccliente;
        private System.Windows.Forms.Label Lempleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_venta;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
    }
}