namespace SaborAcielo
{
    partial class FlistaProductosAdmin
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DGlistaProductos = new System.Windows.Forms.DataGridView();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GBfiltroProductos = new System.Windows.Forms.GroupBox();
            this.CfiltroTipo = new System.Windows.Forms.ComboBox();
            this.CnombreProd = new System.Windows.Forms.ComboBox();
            this.BbuscarProducto = new System.Windows.Forms.Button();
            this.CBtodosProductos = new System.Windows.Forms.CheckBox();
            this.ltipo = new System.Windows.Forms.Label();
            this.Lnombre = new System.Windows.Forms.Label();
            this.PagregarProdu = new System.Windows.Forms.Panel();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.TBdetalle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CtipoProd = new System.Windows.Forms.ComboBox();
            this.BeditarProd = new System.Windows.Forms.Button();
            this.BexaminarImProdu = new System.Windows.Forms.Button();
            this.PBproducto = new System.Windows.Forms.PictureBox();
            this.BagregarProdu = new System.Windows.Forms.Button();
            this.TBcantidadProdu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TBprecio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TBnomProdu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BcancelProdu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGlistaProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            this.GBfiltroProductos.SuspendLayout();
            this.PagregarProdu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBproducto)).BeginInit();
            this.SuspendLayout();
            // 
            // DGlistaProductos
            // 
            this.DGlistaProductos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGlistaProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGlistaProductos.BackgroundColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGlistaProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGlistaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGlistaProductos.Location = new System.Drawing.Point(32, 318);
            this.DGlistaProductos.Margin = new System.Windows.Forms.Padding(2);
            this.DGlistaProductos.Name = "DGlistaProductos";
            this.DGlistaProductos.RowHeadersWidth = 62;
            this.DGlistaProductos.RowTemplate.Height = 28;
            this.DGlistaProductos.Size = new System.Drawing.Size(747, 301);
            this.DGlistaProductos.TabIndex = 6;
            this.DGlistaProductos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DGlistaProductos_CellFormatting);
            // 
            // GBfiltroProductos
            // 
            this.GBfiltroProductos.BackColor = System.Drawing.Color.Transparent;
            this.GBfiltroProductos.Controls.Add(this.CfiltroTipo);
            this.GBfiltroProductos.Controls.Add(this.CnombreProd);
            this.GBfiltroProductos.Controls.Add(this.BbuscarProducto);
            this.GBfiltroProductos.Controls.Add(this.CBtodosProductos);
            this.GBfiltroProductos.Controls.Add(this.ltipo);
            this.GBfiltroProductos.Controls.Add(this.Lnombre);
            this.GBfiltroProductos.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold);
            this.GBfiltroProductos.Location = new System.Drawing.Point(19, 15);
            this.GBfiltroProductos.Name = "GBfiltroProductos";
            this.GBfiltroProductos.Size = new System.Drawing.Size(209, 251);
            this.GBfiltroProductos.TabIndex = 5;
            this.GBfiltroProductos.TabStop = false;
            this.GBfiltroProductos.Text = "Filtrar por";
            // 
            // CfiltroTipo
            // 
            this.CfiltroTipo.FormattingEnabled = true;
            this.CfiltroTipo.Location = new System.Drawing.Point(19, 177);
            this.CfiltroTipo.Margin = new System.Windows.Forms.Padding(2);
            this.CfiltroTipo.Name = "CfiltroTipo";
            this.CfiltroTipo.Size = new System.Drawing.Size(159, 27);
            this.CfiltroTipo.TabIndex = 21;
            // 
            // CnombreProd
            // 
            this.CnombreProd.FormattingEnabled = true;
            this.CnombreProd.Location = new System.Drawing.Point(19, 117);
            this.CnombreProd.Margin = new System.Windows.Forms.Padding(2);
            this.CnombreProd.Name = "CnombreProd";
            this.CnombreProd.Size = new System.Drawing.Size(159, 27);
            this.CnombreProd.TabIndex = 20;
            // 
            // BbuscarProducto
            // 
            this.BbuscarProducto.Location = new System.Drawing.Point(55, 215);
            this.BbuscarProducto.Name = "BbuscarProducto";
            this.BbuscarProducto.Size = new System.Drawing.Size(75, 30);
            this.BbuscarProducto.TabIndex = 5;
            this.BbuscarProducto.Text = "Buscar";
            this.BbuscarProducto.UseVisualStyleBackColor = true;
            // 
            // CBtodosProductos
            // 
            this.CBtodosProductos.AutoSize = true;
            this.CBtodosProductos.Location = new System.Drawing.Point(19, 57);
            this.CBtodosProductos.Name = "CBtodosProductos";
            this.CBtodosProductos.Size = new System.Drawing.Size(154, 23);
            this.CBtodosProductos.TabIndex = 2;
            this.CBtodosProductos.Text = "Todos los productos";
            this.CBtodosProductos.UseVisualStyleBackColor = true;
            // 
            // ltipo
            // 
            this.ltipo.AutoSize = true;
            this.ltipo.Location = new System.Drawing.Point(22, 153);
            this.ltipo.Name = "ltipo";
            this.ltipo.Size = new System.Drawing.Size(40, 19);
            this.ltipo.TabIndex = 1;
            this.ltipo.Text = "Tipo";
            // 
            // Lnombre
            // 
            this.Lnombre.AutoSize = true;
            this.Lnombre.Location = new System.Drawing.Point(22, 96);
            this.Lnombre.Name = "Lnombre";
            this.Lnombre.Size = new System.Drawing.Size(61, 19);
            this.Lnombre.TabIndex = 0;
            this.Lnombre.Text = "Nombre";
            // 
            // PagregarProdu
            // 
            this.PagregarProdu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PagregarProdu.AutoScroll = true;
            this.PagregarProdu.BackColor = System.Drawing.Color.RosyBrown;
            this.PagregarProdu.Controls.Add(this.dtFecha);
            this.PagregarProdu.Controls.Add(this.label6);
            this.PagregarProdu.Controls.Add(this.TBdetalle);
            this.PagregarProdu.Controls.Add(this.label2);
            this.PagregarProdu.Controls.Add(this.CtipoProd);
            this.PagregarProdu.Controls.Add(this.BeditarProd);
            this.PagregarProdu.Controls.Add(this.BexaminarImProdu);
            this.PagregarProdu.Controls.Add(this.PBproducto);
            this.PagregarProdu.Controls.Add(this.BagregarProdu);
            this.PagregarProdu.Controls.Add(this.TBcantidadProdu);
            this.PagregarProdu.Controls.Add(this.label5);
            this.PagregarProdu.Controls.Add(this.TBprecio);
            this.PagregarProdu.Controls.Add(this.label4);
            this.PagregarProdu.Controls.Add(this.label3);
            this.PagregarProdu.Controls.Add(this.TBnomProdu);
            this.PagregarProdu.Controls.Add(this.label1);
            this.PagregarProdu.Controls.Add(this.BcancelProdu);
            this.PagregarProdu.Font = new System.Drawing.Font("Script MT Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PagregarProdu.Location = new System.Drawing.Point(242, 15);
            this.PagregarProdu.Margin = new System.Windows.Forms.Padding(2);
            this.PagregarProdu.Name = "PagregarProdu";
            this.PagregarProdu.Size = new System.Drawing.Size(547, 299);
            this.PagregarProdu.TabIndex = 7;
            // 
            // dtFecha
            // 
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha.Location = new System.Drawing.Point(327, 221);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(107, 24);
            this.dtFecha.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(217, 220);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 19);
            this.label6.TabIndex = 22;
            this.label6.Text = "Fecha ingreso";
            // 
            // TBdetalle
            // 
            this.TBdetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TBdetalle.Location = new System.Drawing.Point(111, 103);
            this.TBdetalle.Margin = new System.Windows.Forms.Padding(2);
            this.TBdetalle.Multiline = true;
            this.TBdetalle.Name = "TBdetalle";
            this.TBdetalle.Size = new System.Drawing.Size(228, 70);
            this.TBdetalle.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 19);
            this.label2.TabIndex = 20;
            this.label2.Text = "Detalle";
            // 
            // CtipoProd
            // 
            this.CtipoProd.FormattingEnabled = true;
            this.CtipoProd.Items.AddRange(new object[] {
            "Regular",
            "Vegano",
            "Sin T.A.C.C"});
            this.CtipoProd.Location = new System.Drawing.Point(111, 57);
            this.CtipoProd.Margin = new System.Windows.Forms.Padding(2);
            this.CtipoProd.Name = "CtipoProd";
            this.CtipoProd.Size = new System.Drawing.Size(225, 23);
            this.CtipoProd.TabIndex = 19;
            this.CtipoProd.Text = "--seleccione el tipo de producto";
            // 
            // BeditarProd
            // 
            this.BeditarProd.Font = new System.Drawing.Font("Script MT Bold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BeditarProd.Location = new System.Drawing.Point(71, 265);
            this.BeditarProd.Margin = new System.Windows.Forms.Padding(2);
            this.BeditarProd.Name = "BeditarProd";
            this.BeditarProd.Size = new System.Drawing.Size(115, 32);
            this.BeditarProd.TabIndex = 18;
            this.BeditarProd.Text = "Modificar";
            this.BeditarProd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BeditarProd.UseVisualStyleBackColor = true;
            this.BeditarProd.Click += new System.EventHandler(this.BeditarProd_Click);
            // 
            // BexaminarImProdu
            // 
            this.BexaminarImProdu.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold);
            this.BexaminarImProdu.Location = new System.Drawing.Point(432, 169);
            this.BexaminarImProdu.Name = "BexaminarImProdu";
            this.BexaminarImProdu.Size = new System.Drawing.Size(95, 27);
            this.BexaminarImProdu.TabIndex = 17;
            this.BexaminarImProdu.Text = "Examinar";
            this.BexaminarImProdu.UseVisualStyleBackColor = true;
            this.BexaminarImProdu.Click += new System.EventHandler(this.BexaminarImProdu_Click_1);
            // 
            // PBproducto
            // 
            this.PBproducto.BackgroundImage = global::SaborAcielo.Properties.Resources.ProductosInicio;
            this.PBproducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PBproducto.Location = new System.Drawing.Point(392, 14);
            this.PBproducto.Name = "PBproducto";
            this.PBproducto.Size = new System.Drawing.Size(135, 135);
            this.PBproducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBproducto.TabIndex = 16;
            this.PBproducto.TabStop = false;
            // 
            // BagregarProdu
            // 
            this.BagregarProdu.Font = new System.Drawing.Font("Script MT Bold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BagregarProdu.Location = new System.Drawing.Point(71, 265);
            this.BagregarProdu.Margin = new System.Windows.Forms.Padding(2);
            this.BagregarProdu.Name = "BagregarProdu";
            this.BagregarProdu.Size = new System.Drawing.Size(115, 32);
            this.BagregarProdu.TabIndex = 15;
            this.BagregarProdu.Text = "Agregar";
            this.BagregarProdu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BagregarProdu.UseVisualStyleBackColor = true;
            this.BagregarProdu.Click += new System.EventHandler(this.BagregarProdu_Click_1);
            // 
            // TBcantidadProdu
            // 
            this.TBcantidadProdu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TBcantidadProdu.Location = new System.Drawing.Point(111, 218);
            this.TBcantidadProdu.Margin = new System.Windows.Forms.Padding(2);
            this.TBcantidadProdu.Name = "TBcantidadProdu";
            this.TBcantidadProdu.Size = new System.Drawing.Size(62, 26);
            this.TBcantidadProdu.TabIndex = 11;
            this.TBcantidadProdu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBcantidadProdu_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 219);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Stock";
            // 
            // TBprecio
            // 
            this.TBprecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TBprecio.Location = new System.Drawing.Point(111, 177);
            this.TBprecio.Margin = new System.Windows.Forms.Padding(2);
            this.TBprecio.Name = "TBprecio";
            this.TBprecio.Size = new System.Drawing.Size(229, 26);
            this.TBprecio.TabIndex = 9;
            this.TBprecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBprecio_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 57);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tipo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 177);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Precio";
            // 
            // TBnomProdu
            // 
            this.TBnomProdu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TBnomProdu.Location = new System.Drawing.Point(111, 10);
            this.TBnomProdu.Margin = new System.Windows.Forms.Padding(2);
            this.TBnomProdu.Name = "TBnomProdu";
            this.TBnomProdu.Size = new System.Drawing.Size(229, 26);
            this.TBnomProdu.TabIndex = 3;
            this.TBnomProdu.TextChanged += new System.EventHandler(this.TBnomProdu_TextChanged);
            this.TBnomProdu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBnomProdu_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // BcancelProdu
            // 
            this.BcancelProdu.Font = new System.Drawing.Font("Script MT Bold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BcancelProdu.Image = global::SaborAcielo.Properties.Resources.cruz;
            this.BcancelProdu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BcancelProdu.Location = new System.Drawing.Point(221, 265);
            this.BcancelProdu.Margin = new System.Windows.Forms.Padding(2);
            this.BcancelProdu.Name = "BcancelProdu";
            this.BcancelProdu.Size = new System.Drawing.Size(113, 32);
            this.BcancelProdu.TabIndex = 1;
            this.BcancelProdu.Text = "Cancelar";
            this.BcancelProdu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BcancelProdu.UseVisualStyleBackColor = true;
            this.BcancelProdu.Click += new System.EventHandler(this.BcancelProdu_Click);
            // 
            // FlistaProductosAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SaborAcielo.Properties.Resources.fondoSACinicio;
            this.ClientSize = new System.Drawing.Size(800, 512);
            this.Controls.Add(this.PagregarProdu);
            this.Controls.Add(this.DGlistaProductos);
            this.Controls.Add(this.GBfiltroProductos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FlistaProductosAdmin";
            this.Text = "Lista de Productos";
            this.Load += new System.EventHandler(this.FlistaProductosAdmin_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.DGlistaProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            this.GBfiltroProductos.ResumeLayout(false);
            this.GBfiltroProductos.PerformLayout();
            this.PagregarProdu.ResumeLayout(false);
            this.PagregarProdu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBproducto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGlistaProductos;
        private System.Windows.Forms.GroupBox GBfiltroProductos;
        private System.Windows.Forms.CheckBox CBtodosProductos;
        private System.Windows.Forms.Label ltipo;
        private System.Windows.Forms.Label Lnombre;
        private System.Windows.Forms.Panel PagregarProdu;
        private System.Windows.Forms.Button BagregarProdu;
        private System.Windows.Forms.TextBox TBcantidadProdu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TBprecio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBnomProdu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BcancelProdu;
        private System.Windows.Forms.Button BexaminarImProdu;
        private System.Windows.Forms.PictureBox PBproducto;
        private System.Windows.Forms.Button BbuscarProducto;
        private System.Windows.Forms.Button BeditarProd;
        private System.Windows.Forms.ComboBox CtipoProd;
        private System.Windows.Forms.TextBox TBdetalle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CfiltroTipo;
        private System.Windows.Forms.ComboBox CnombreProd;
        private System.Windows.Forms.DateTimePicker dtFecha;
       // private SaborAcieloDataSet1 saborAcieloDataSet1;
        private System.Windows.Forms.BindingSource productoBindingSource;
        //private SaborAcieloDataSet1TableAdapters.ProductoTableAdapter productoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idproduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreproduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detalleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn estadoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imagenDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtipoProduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
    }
}