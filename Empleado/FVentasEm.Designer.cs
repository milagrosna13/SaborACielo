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
            this.label2 = new System.Windows.Forms.Label();
            this.Pventas = new System.Windows.Forms.Panel();
            this.GBfiltroVenta = new System.Windows.Forms.GroupBox();
            this.Fcliente = new System.Windows.Forms.TextBox();
            this.Fprodu = new System.Windows.Forms.TextBox();
            this.CBProducto = new System.Windows.Forms.CheckBox();
            this.CBcliente = new System.Windows.Forms.CheckBox();
            this.CBfecha = new System.Windows.Forms.CheckBox();
            this.DThasta = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.DTdesde = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.id_venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dni_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalle_compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGventas)).BeginInit();
            this.Pventas.SuspendLayout();
            this.GBfiltroVenta.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGventas
            // 
            this.DGventas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
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
            this.DGventas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_venta,
            this.dni_cliente,
            this.total,
            this.fecha,
            this.detalle_compra});
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
            this.Pventas.Controls.Add(this.GBfiltroVenta);
            this.Pventas.Controls.Add(this.label2);
            this.Pventas.Font = new System.Drawing.Font("Script MT Bold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pventas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Pventas.Location = new System.Drawing.Point(84, 50);
            this.Pventas.Name = "Pventas";
            this.Pventas.Size = new System.Drawing.Size(993, 335);
            this.Pventas.TabIndex = 3;
            // 
            // GBfiltroVenta
            // 
            this.GBfiltroVenta.Controls.Add(this.Fcliente);
            this.GBfiltroVenta.Controls.Add(this.Fprodu);
            this.GBfiltroVenta.Controls.Add(this.CBProducto);
            this.GBfiltroVenta.Controls.Add(this.CBcliente);
            this.GBfiltroVenta.Controls.Add(this.CBfecha);
            this.GBfiltroVenta.Controls.Add(this.DThasta);
            this.GBfiltroVenta.Controls.Add(this.label5);
            this.GBfiltroVenta.Controls.Add(this.DTdesde);
            this.GBfiltroVenta.Controls.Add(this.label4);
            this.GBfiltroVenta.Location = new System.Drawing.Point(35, 63);
            this.GBfiltroVenta.Name = "GBfiltroVenta";
            this.GBfiltroVenta.Size = new System.Drawing.Size(908, 247);
            this.GBfiltroVenta.TabIndex = 8;
            this.GBfiltroVenta.TabStop = false;
            this.GBfiltroVenta.Text = "Filtrar por";
            // 
            // Fcliente
            // 
            this.Fcliente.Location = new System.Drawing.Point(223, 104);
            this.Fcliente.Name = "Fcliente";
            this.Fcliente.Size = new System.Drawing.Size(268, 34);
            this.Fcliente.TabIndex = 14;
            // 
            // Fprodu
            // 
            this.Fprodu.Location = new System.Drawing.Point(223, 176);
            this.Fprodu.Name = "Fprodu";
            this.Fprodu.Size = new System.Drawing.Size(258, 34);
            this.Fprodu.TabIndex = 13;
            this.Fprodu.TextChanged += new System.EventHandler(this.Fprodu_TextChanged);
            // 
            // CBProducto
            // 
            this.CBProducto.AutoSize = true;
            this.CBProducto.Location = new System.Drawing.Point(28, 176);
            this.CBProducto.Name = "CBProducto";
            this.CBProducto.Size = new System.Drawing.Size(117, 31);
            this.CBProducto.TabIndex = 12;
            this.CBProducto.Text = "Producto";
            this.CBProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CBProducto.UseVisualStyleBackColor = true;
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
            // id_venta
            // 
            this.id_venta.HeaderText = "Venta nr";
            this.id_venta.MinimumWidth = 8;
            this.id_venta.Name = "id_venta";
            // 
            // dni_cliente
            // 
            this.dni_cliente.HeaderText = "Cliente";
            this.dni_cliente.MinimumWidth = 8;
            this.dni_cliente.Name = "dni_cliente";
            // 
            // total
            // 
            this.total.HeaderText = "Total";
            this.total.MinimumWidth = 8;
            this.total.Name = "total";
            // 
            // fecha
            // 
            this.fecha.HeaderText = "Fecha";
            this.fecha.MinimumWidth = 8;
            this.fecha.Name = "fecha";
            // 
            // detalle_compra
            // 
            this.detalle_compra.HeaderText = "Detalle";
            this.detalle_compra.MinimumWidth = 8;
            this.detalle_compra.Name = "detalle_compra";
            this.detalle_compra.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.detalle_compra.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FVentasEm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SaborAcielo.Properties.Resources.fondoSACinicio;
            this.ClientSize = new System.Drawing.Size(1225, 773);
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
        private System.Windows.Forms.TextBox Fcliente;
        private System.Windows.Forms.TextBox Fprodu;
        private System.Windows.Forms.CheckBox CBProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_venta;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn detalle_compra;
    }
}