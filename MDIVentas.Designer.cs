namespace SaborAcielo
{
    partial class MDIVentas
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id_venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GBfiltroVentas = new System.Windows.Forms.GroupBox();
            this.GBvendedor = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.GBfecha = new System.Windows.Forms.GroupBox();
            this.Ldesde = new System.Windows.Forms.Label();
            this.Lhasta = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.GBcliente = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CBtodasVentas = new System.Windows.Forms.CheckBox();
            this.BbuscarVenta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.GBfiltroVentas.SuspendLayout();
            this.GBvendedor.SuspendLayout();
            this.GBfecha.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_venta,
            this.id_cliente,
            this.cod_producto,
            this.total,
            this.fecha,
            this.vendedor});
            this.dataGridView1.Location = new System.Drawing.Point(123, 325);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(644, 224);
            this.dataGridView1.TabIndex = 4;
            // 
            // id_venta
            // 
            this.id_venta.HeaderText = "id_venta";
            this.id_venta.Name = "id_venta";
            // 
            // id_cliente
            // 
            this.id_cliente.HeaderText = "id_cliente";
            this.id_cliente.Name = "id_cliente";
            // 
            // cod_producto
            // 
            this.cod_producto.HeaderText = "cod_producto";
            this.cod_producto.Name = "cod_producto";
            // 
            // total
            // 
            this.total.HeaderText = "total";
            this.total.Name = "total";
            // 
            // fecha
            // 
            this.fecha.HeaderText = "fecha";
            this.fecha.Name = "fecha";
            // 
            // vendedor
            // 
            this.vendedor.HeaderText = "vendedor";
            this.vendedor.Name = "vendedor";
            // 
            // GBfiltroVentas
            // 
            this.GBfiltroVentas.BackColor = System.Drawing.Color.Transparent;
            this.GBfiltroVentas.Controls.Add(this.BbuscarVenta);
            this.GBfiltroVentas.Controls.Add(this.CBtodasVentas);
            this.GBfiltroVentas.Controls.Add(this.groupBox2);
            this.GBfiltroVentas.Controls.Add(this.GBcliente);
            this.GBfiltroVentas.Controls.Add(this.GBfecha);
            this.GBfiltroVentas.Controls.Add(this.GBvendedor);
            this.GBfiltroVentas.Font = new System.Drawing.Font("Script MT Bold", 15F, System.Drawing.FontStyle.Bold);
            this.GBfiltroVentas.Location = new System.Drawing.Point(323, 118);
            this.GBfiltroVentas.Name = "GBfiltroVentas";
            this.GBfiltroVentas.Size = new System.Drawing.Size(549, 184);
            this.GBfiltroVentas.TabIndex = 5;
            this.GBfiltroVentas.TabStop = false;
            this.GBfiltroVentas.Text = "Filtrar Ventas";
            // 
            // GBvendedor
            // 
            this.GBvendedor.Controls.Add(this.comboBox1);
            this.GBvendedor.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold);
            this.GBvendedor.Location = new System.Drawing.Point(6, 68);
            this.GBvendedor.Name = "GBvendedor";
            this.GBvendedor.Size = new System.Drawing.Size(162, 52);
            this.GBvendedor.TabIndex = 0;
            this.GBvendedor.TabStop = false;
            this.GBvendedor.Text = "Vendedor";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(17, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 27);
            this.comboBox1.TabIndex = 0;
            // 
            // GBfecha
            // 
            this.GBfecha.Controls.Add(this.dateTimePicker2);
            this.GBfecha.Controls.Add(this.dateTimePicker1);
            this.GBfecha.Controls.Add(this.Lhasta);
            this.GBfecha.Controls.Add(this.Ldesde);
            this.GBfecha.Location = new System.Drawing.Point(174, 31);
            this.GBfecha.Name = "GBfecha";
            this.GBfecha.Size = new System.Drawing.Size(93, 148);
            this.GBfecha.TabIndex = 1;
            this.GBfecha.TabStop = false;
            this.GBfecha.Text = "Fecha";
            // 
            // Ldesde
            // 
            this.Ldesde.AutoSize = true;
            this.Ldesde.Location = new System.Drawing.Point(7, 37);
            this.Ldesde.Name = "Ldesde";
            this.Ldesde.Size = new System.Drawing.Size(57, 24);
            this.Ldesde.TabIndex = 0;
            this.Ldesde.Text = "Desde";
            // 
            // Lhasta
            // 
            this.Lhasta.AutoSize = true;
            this.Lhasta.Location = new System.Drawing.Point(7, 83);
            this.Lhasta.Name = "Lhasta";
            this.Lhasta.Size = new System.Drawing.Size(62, 24);
            this.Lhasta.TabIndex = 1;
            this.Lhasta.Text = "Hasta";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Script MT Bold", 9.5F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 60);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(82, 23);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Script MT Bold", 9.5F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(5, 110);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(82, 23);
            this.dateTimePicker2.TabIndex = 3;
            // 
            // GBcliente
            // 
            this.GBcliente.Location = new System.Drawing.Point(273, 44);
            this.GBcliente.Name = "GBcliente";
            this.GBcliente.Size = new System.Drawing.Size(270, 48);
            this.GBcliente.TabIndex = 2;
            this.GBcliente.TabStop = false;
            this.GBcliente.Text = "Cliente";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(273, 114);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(270, 50);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Codigo Venta";
            // 
            // CBtodasVentas
            // 
            this.CBtodasVentas.AutoSize = true;
            this.CBtodasVentas.Location = new System.Drawing.Point(6, 34);
            this.CBtodasVentas.Name = "CBtodasVentas";
            this.CBtodasVentas.Size = new System.Drawing.Size(164, 28);
            this.CBtodasVentas.TabIndex = 4;
            this.CBtodasVentas.Text = "Todas las ventas";
            this.CBtodasVentas.UseVisualStyleBackColor = true;
            // 
            // BbuscarVenta
            // 
            this.BbuscarVenta.Location = new System.Drawing.Point(23, 134);
            this.BbuscarVenta.Name = "BbuscarVenta";
            this.BbuscarVenta.Size = new System.Drawing.Size(121, 37);
            this.BbuscarVenta.TabIndex = 5;
            this.BbuscarVenta.Text = "Buscar";
            this.BbuscarVenta.UseVisualStyleBackColor = true;
            // 
            // MDIVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.GBfiltroVentas);
            this.Controls.Add(this.dataGridView1);
            this.IsMdiContainer = true;
            this.Name = "MDIVentas";
            this.Text = "MDIParent1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.GBfiltroVentas.ResumeLayout(false);
            this.GBfiltroVentas.PerformLayout();
            this.GBvendedor.ResumeLayout(false);
            this.GBfecha.ResumeLayout(false);
            this.GBfecha.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_venta;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendedor;
        private System.Windows.Forms.GroupBox GBfiltroVentas;
        private System.Windows.Forms.GroupBox GBvendedor;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox GBfecha;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label Lhasta;
        private System.Windows.Forms.Label Ldesde;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox GBcliente;
        private System.Windows.Forms.Button BbuscarVenta;
        private System.Windows.Forms.CheckBox CBtodasVentas;
    }
}



