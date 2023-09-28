namespace SaborAcielo
{
    partial class Fproducto
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
            this.GBfiltroProductos = new System.Windows.Forms.GroupBox();
            this.CtipoProd = new System.Windows.Forms.ComboBox();
            this.CnombreProd = new System.Windows.Forms.ComboBox();
            this.BbuscarProducto = new System.Windows.Forms.Button();
            this.CBtodosProductos = new System.Windows.Forms.CheckBox();
            this.ltipo = new System.Windows.Forms.Label();
            this.Lnombre = new System.Windows.Forms.Label();
            this.DGlistaProductos = new System.Windows.Forms.DataGridView();
            this.nombre_prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_tipoproducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion_prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cant_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foto_producto = new System.Windows.Forms.DataGridViewImageColumn();
            this.GBfiltroProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGlistaProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // GBfiltroProductos
            // 
            this.GBfiltroProductos.BackColor = System.Drawing.Color.Transparent;
            this.GBfiltroProductos.Controls.Add(this.CtipoProd);
            this.GBfiltroProductos.Controls.Add(this.CnombreProd);
            this.GBfiltroProductos.Controls.Add(this.BbuscarProducto);
            this.GBfiltroProductos.Controls.Add(this.CBtodosProductos);
            this.GBfiltroProductos.Controls.Add(this.ltipo);
            this.GBfiltroProductos.Controls.Add(this.Lnombre);
            this.GBfiltroProductos.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBfiltroProductos.Location = new System.Drawing.Point(31, 12);
            this.GBfiltroProductos.Name = "GBfiltroProductos";
            this.GBfiltroProductos.Size = new System.Drawing.Size(714, 100);
            this.GBfiltroProductos.TabIndex = 1;
            this.GBfiltroProductos.TabStop = false;
            this.GBfiltroProductos.Text = "Filtrar por";
            // 
            // CtipoProd
            // 
            this.CtipoProd.FormattingEnabled = true;
            this.CtipoProd.Location = new System.Drawing.Point(479, 57);
            this.CtipoProd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CtipoProd.Name = "CtipoProd";
            this.CtipoProd.Size = new System.Drawing.Size(159, 27);
            this.CtipoProd.TabIndex = 22;
            // 
            // CnombreProd
            // 
            this.CnombreProd.FormattingEnabled = true;
            this.CnombreProd.Location = new System.Drawing.Point(279, 57);
            this.CnombreProd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CnombreProd.Name = "CnombreProd";
            this.CnombreProd.Size = new System.Drawing.Size(159, 27);
            this.CnombreProd.TabIndex = 21;
            // 
            // BbuscarProducto
            // 
            this.BbuscarProducto.Location = new System.Drawing.Point(66, 60);
            this.BbuscarProducto.Name = "BbuscarProducto";
            this.BbuscarProducto.Size = new System.Drawing.Size(75, 34);
            this.BbuscarProducto.TabIndex = 5;
            this.BbuscarProducto.Text = "Buscar";
            this.BbuscarProducto.UseVisualStyleBackColor = true;
            // 
            // CBtodosProductos
            // 
            this.CBtodosProductos.AutoSize = true;
            this.CBtodosProductos.Location = new System.Drawing.Point(22, 26);
            this.CBtodosProductos.Name = "CBtodosProductos";
            this.CBtodosProductos.Size = new System.Drawing.Size(154, 23);
            this.CBtodosProductos.TabIndex = 2;
            this.CBtodosProductos.Text = "Todos los productos";
            this.CBtodosProductos.UseVisualStyleBackColor = true;
            // 
            // ltipo
            // 
            this.ltipo.AutoSize = true;
            this.ltipo.Location = new System.Drawing.Point(494, 20);
            this.ltipo.Name = "ltipo";
            this.ltipo.Size = new System.Drawing.Size(40, 19);
            this.ltipo.TabIndex = 1;
            this.ltipo.Text = "Tipo";
            // 
            // Lnombre
            // 
            this.Lnombre.AutoSize = true;
            this.Lnombre.Location = new System.Drawing.Point(287, 20);
            this.Lnombre.Name = "Lnombre";
            this.Lnombre.Size = new System.Drawing.Size(61, 19);
            this.Lnombre.TabIndex = 0;
            this.Lnombre.Text = "Nombre";
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
            this.DGlistaProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre_prod,
            this.id_tipoproducto,
            this.descripcion_prod,
            this.precio_unitario,
            this.cant_producto,
            this.estado,
            this.foto_producto});
            this.DGlistaProductos.Location = new System.Drawing.Point(19, 141);
            this.DGlistaProductos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DGlistaProductos.Name = "DGlistaProductos";
            this.DGlistaProductos.RowHeadersWidth = 62;
            this.DGlistaProductos.RowTemplate.Height = 28;
            this.DGlistaProductos.Size = new System.Drawing.Size(747, 301);
            this.DGlistaProductos.TabIndex = 7;
            // 
            // nombre_prod
            // 
            this.nombre_prod.HeaderText = "Nombre";
            this.nombre_prod.MinimumWidth = 8;
            this.nombre_prod.Name = "nombre_prod";
            // 
            // id_tipoproducto
            // 
            this.id_tipoproducto.HeaderText = "Tipo";
            this.id_tipoproducto.MinimumWidth = 8;
            this.id_tipoproducto.Name = "id_tipoproducto";
            // 
            // descripcion_prod
            // 
            this.descripcion_prod.HeaderText = "Detalle";
            this.descripcion_prod.MinimumWidth = 8;
            this.descripcion_prod.Name = "descripcion_prod";
            // 
            // precio_unitario
            // 
            this.precio_unitario.HeaderText = "Precio";
            this.precio_unitario.MinimumWidth = 8;
            this.precio_unitario.Name = "precio_unitario";
            // 
            // cant_producto
            // 
            this.cant_producto.HeaderText = "Stock";
            this.cant_producto.MinimumWidth = 8;
            this.cant_producto.Name = "cant_producto";
            // 
            // estado
            // 
            this.estado.HeaderText = "Estado";
            this.estado.MinimumWidth = 8;
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            // 
            // foto_producto
            // 
            this.foto_producto.HeaderText = "Imagen";
            this.foto_producto.Image = global::SaborAcielo.Properties.Resources.decoracion_de_pasteles;
            this.foto_producto.MinimumWidth = 8;
            this.foto_producto.Name = "foto_producto";
            this.foto_producto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Fproducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SaborAcielo.Properties.Resources.fondoSACinicio;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DGlistaProductos);
            this.Controls.Add(this.GBfiltroProductos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Fproducto";
            this.Text = "Lista de Productos";
            this.GBfiltroProductos.ResumeLayout(false);
            this.GBfiltroProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGlistaProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox GBfiltroProductos;
        private System.Windows.Forms.Label ltipo;
        private System.Windows.Forms.Label Lnombre;
        private System.Windows.Forms.CheckBox CBtodosProductos;
        private System.Windows.Forms.Button BbuscarProducto;
        private System.Windows.Forms.ComboBox CtipoProd;
        private System.Windows.Forms.ComboBox CnombreProd;
        private System.Windows.Forms.DataGridView DGlistaProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_prod;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_tipoproducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion_prod;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_unitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn cant_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewImageColumn foto_producto;
    }
}