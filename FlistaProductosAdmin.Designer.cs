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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DGlistaProductos = new System.Windows.Forms.DataGridView();
            this.GBfiltroProductos = new System.Windows.Forms.GroupBox();
            this.BbuscarProducto = new System.Windows.Forms.Button();
            this.CBtodosProductos = new System.Windows.Forms.CheckBox();
            this.ltipo = new System.Windows.Forms.Label();
            this.Lnombre = new System.Windows.Forms.Label();
            this.PagregarProdu = new System.Windows.Forms.Panel();
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
            this.CtipoProd = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.CnombreProd = new System.Windows.Forms.ComboBox();
            this.CfiltroTipo = new System.Windows.Forms.ComboBox();
            this.nombre_prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_tipoproducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion_prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cant_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foto_producto = new System.Windows.Forms.DataGridViewImageColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar_produ = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar_produ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGlistaProductos)).BeginInit();
            this.GBfiltroProductos.SuspendLayout();
            this.PagregarProdu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBproducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
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
            this.DGlistaProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre_prod,
            this.id_tipoproducto,
            this.descripcion_prod,
            this.precio_unitario,
            this.cant_producto,
            this.foto_producto,
            this.estado,
            this.Editar_produ,
            this.Eliminar_produ});
            this.DGlistaProductos.Location = new System.Drawing.Point(48, 489);
            this.DGlistaProductos.Name = "DGlistaProductos";
            this.DGlistaProductos.RowHeadersWidth = 62;
            this.DGlistaProductos.RowTemplate.Height = 28;
            this.DGlistaProductos.Size = new System.Drawing.Size(1120, 463);
            this.DGlistaProductos.TabIndex = 6;
            this.DGlistaProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGlistaProductos_CellClick);
            this.DGlistaProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGlistaProductos_CellContentClick);
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
            this.GBfiltroProductos.Location = new System.Drawing.Point(29, 23);
            this.GBfiltroProductos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GBfiltroProductos.Name = "GBfiltroProductos";
            this.GBfiltroProductos.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GBfiltroProductos.Size = new System.Drawing.Size(313, 386);
            this.GBfiltroProductos.TabIndex = 5;
            this.GBfiltroProductos.TabStop = false;
            this.GBfiltroProductos.Text = "Filtrar por";
            // 
            // BbuscarProducto
            // 
            this.BbuscarProducto.Location = new System.Drawing.Point(82, 331);
            this.BbuscarProducto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BbuscarProducto.Name = "BbuscarProducto";
            this.BbuscarProducto.Size = new System.Drawing.Size(112, 46);
            this.BbuscarProducto.TabIndex = 5;
            this.BbuscarProducto.Text = "Buscar";
            this.BbuscarProducto.UseVisualStyleBackColor = true;
            // 
            // CBtodosProductos
            // 
            this.CBtodosProductos.AutoSize = true;
            this.CBtodosProductos.Location = new System.Drawing.Point(28, 88);
            this.CBtodosProductos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CBtodosProductos.Name = "CBtodosProductos";
            this.CBtodosProductos.Size = new System.Drawing.Size(238, 33);
            this.CBtodosProductos.TabIndex = 2;
            this.CBtodosProductos.Text = "Todos los productos";
            this.CBtodosProductos.UseVisualStyleBackColor = true;
            // 
            // ltipo
            // 
            this.ltipo.AutoSize = true;
            this.ltipo.Location = new System.Drawing.Point(33, 235);
            this.ltipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ltipo.Name = "ltipo";
            this.ltipo.Size = new System.Drawing.Size(60, 29);
            this.ltipo.TabIndex = 1;
            this.ltipo.Text = "Tipo";
            // 
            // Lnombre
            // 
            this.Lnombre.AutoSize = true;
            this.Lnombre.Location = new System.Drawing.Point(33, 148);
            this.Lnombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lnombre.Name = "Lnombre";
            this.Lnombre.Size = new System.Drawing.Size(91, 29);
            this.Lnombre.TabIndex = 0;
            this.Lnombre.Text = "Nombre";
            // 
            // PagregarProdu
            // 
            this.PagregarProdu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PagregarProdu.AutoScroll = true;
            this.PagregarProdu.BackColor = System.Drawing.Color.RosyBrown;
            this.PagregarProdu.Controls.Add(this.numericUpDown1);
            this.PagregarProdu.Controls.Add(this.label6);
            this.PagregarProdu.Controls.Add(this.textBox1);
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
            this.PagregarProdu.Location = new System.Drawing.Point(363, 23);
            this.PagregarProdu.Name = "PagregarProdu";
            this.PagregarProdu.Size = new System.Drawing.Size(821, 460);
            this.PagregarProdu.TabIndex = 7;
            // 
            // BeditarProd
            // 
            this.BeditarProd.Font = new System.Drawing.Font("Script MT Bold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BeditarProd.Location = new System.Drawing.Point(106, 408);
            this.BeditarProd.Name = "BeditarProd";
            this.BeditarProd.Size = new System.Drawing.Size(172, 49);
            this.BeditarProd.TabIndex = 18;
            this.BeditarProd.Text = "Modificar";
            this.BeditarProd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BeditarProd.UseVisualStyleBackColor = true;
            this.BeditarProd.Click += new System.EventHandler(this.BeditarProd_Click);
            // 
            // BexaminarImProdu
            // 
            this.BexaminarImProdu.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold);
            this.BexaminarImProdu.Location = new System.Drawing.Point(648, 260);
            this.BexaminarImProdu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BexaminarImProdu.Name = "BexaminarImProdu";
            this.BexaminarImProdu.Size = new System.Drawing.Size(142, 42);
            this.BexaminarImProdu.TabIndex = 17;
            this.BexaminarImProdu.Text = "Examinar";
            this.BexaminarImProdu.UseVisualStyleBackColor = true;
            this.BexaminarImProdu.Click += new System.EventHandler(this.BexaminarImProdu_Click_1);
            // 
            // PBproducto
            // 
            this.PBproducto.BackgroundImage = global::SaborAcielo.Properties.Resources.ProductosInicio;
            this.PBproducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PBproducto.Location = new System.Drawing.Point(588, 22);
            this.PBproducto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PBproducto.Name = "PBproducto";
            this.PBproducto.Size = new System.Drawing.Size(202, 208);
            this.PBproducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBproducto.TabIndex = 16;
            this.PBproducto.TabStop = false;
            // 
            // BagregarProdu
            // 
            this.BagregarProdu.Font = new System.Drawing.Font("Script MT Bold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BagregarProdu.Location = new System.Drawing.Point(106, 408);
            this.BagregarProdu.Name = "BagregarProdu";
            this.BagregarProdu.Size = new System.Drawing.Size(172, 49);
            this.BagregarProdu.TabIndex = 15;
            this.BagregarProdu.Text = "Agregar";
            this.BagregarProdu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BagregarProdu.UseVisualStyleBackColor = true;
            this.BagregarProdu.Click += new System.EventHandler(this.BagregarProdu_Click_1);
            // 
            // TBcantidadProdu
            // 
            this.TBcantidadProdu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TBcantidadProdu.Location = new System.Drawing.Point(166, 336);
            this.TBcantidadProdu.Name = "TBcantidadProdu";
            this.TBcantidadProdu.Size = new System.Drawing.Size(91, 35);
            this.TBcantidadProdu.TabIndex = 11;
            this.TBcantidadProdu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBcantidadProdu_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(56, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "Stock";
            // 
            // TBprecio
            // 
            this.TBprecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TBprecio.Location = new System.Drawing.Point(166, 273);
            this.TBprecio.Name = "TBprecio";
            this.TBprecio.Size = new System.Drawing.Size(341, 35);
            this.TBprecio.TabIndex = 9;
            this.TBprecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBprecio_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tipo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Precio";
            // 
            // TBnomProdu
            // 
            this.TBnomProdu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TBnomProdu.Location = new System.Drawing.Point(166, 15);
            this.TBnomProdu.Name = "TBnomProdu";
            this.TBnomProdu.Size = new System.Drawing.Size(341, 35);
            this.TBnomProdu.TabIndex = 3;
            this.TBnomProdu.TextChanged += new System.EventHandler(this.TBnomProdu_TextChanged);
            this.TBnomProdu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBnomProdu_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // BcancelProdu
            // 
            this.BcancelProdu.Font = new System.Drawing.Font("Script MT Bold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BcancelProdu.Image = global::SaborAcielo.Properties.Resources.cruz;
            this.BcancelProdu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BcancelProdu.Location = new System.Drawing.Point(331, 408);
            this.BcancelProdu.Name = "BcancelProdu";
            this.BcancelProdu.Size = new System.Drawing.Size(170, 49);
            this.BcancelProdu.TabIndex = 1;
            this.BcancelProdu.Text = "Cancelar";
            this.BcancelProdu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BcancelProdu.UseVisualStyleBackColor = true;
            this.BcancelProdu.Click += new System.EventHandler(this.BcancelProdu_Click);
            // 
            // CtipoProd
            // 
            this.CtipoProd.FormattingEnabled = true;
            this.CtipoProd.Location = new System.Drawing.Point(166, 88);
            this.CtipoProd.Name = "CtipoProd";
            this.CtipoProd.Size = new System.Drawing.Size(335, 32);
            this.CtipoProd.TabIndex = 19;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox1.Location = new System.Drawing.Point(167, 159);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(340, 105);
            this.textBox1.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 29);
            this.label2.TabIndex = 20;
            this.label2.Text = "Detalle";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(326, 339);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 29);
            this.label6.TabIndex = 22;
            this.label6.Text = "Stock min";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(447, 339);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 32);
            this.numericUpDown1.TabIndex = 24;
            // 
            // CnombreProd
            // 
            this.CnombreProd.FormattingEnabled = true;
            this.CnombreProd.Location = new System.Drawing.Point(28, 180);
            this.CnombreProd.Name = "CnombreProd";
            this.CnombreProd.Size = new System.Drawing.Size(237, 37);
            this.CnombreProd.TabIndex = 20;
            // 
            // CfiltroTipo
            // 
            this.CfiltroTipo.FormattingEnabled = true;
            this.CfiltroTipo.Location = new System.Drawing.Point(28, 273);
            this.CfiltroTipo.Name = "CfiltroTipo";
            this.CfiltroTipo.Size = new System.Drawing.Size(237, 37);
            this.CfiltroTipo.TabIndex = 21;
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
            // foto_producto
            // 
            this.foto_producto.HeaderText = "Imagen";
            this.foto_producto.Image = global::SaborAcielo.Properties.Resources.decoracion_de_pasteles;
            this.foto_producto.MinimumWidth = 8;
            this.foto_producto.Name = "foto_producto";
            this.foto_producto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // estado
            // 
            this.estado.HeaderText = "Estado";
            this.estado.MinimumWidth = 8;
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            // 
            // Editar_produ
            // 
            this.Editar_produ.HeaderText = "Editar";
            this.Editar_produ.MinimumWidth = 8;
            this.Editar_produ.Name = "Editar_produ";
            this.Editar_produ.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Editar_produ.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Eliminar_produ
            // 
            this.Eliminar_produ.HeaderText = "Eliminar";
            this.Eliminar_produ.MinimumWidth = 8;
            this.Eliminar_produ.Name = "Eliminar_produ";
            // 
            // FlistaProductosAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SaborAcielo.Properties.Resources.fondoSACinicio;
            this.ClientSize = new System.Drawing.Size(1200, 875);
            this.Controls.Add(this.PagregarProdu);
            this.Controls.Add(this.DGlistaProductos);
            this.Controls.Add(this.GBfiltroProductos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FlistaProductosAdmin";
            this.Text = "Lista de Productos";
            ((System.ComponentModel.ISupportInitialize)(this.DGlistaProductos)).EndInit();
            this.GBfiltroProductos.ResumeLayout(false);
            this.GBfiltroProductos.PerformLayout();
            this.PagregarProdu.ResumeLayout(false);
            this.PagregarProdu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBproducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CfiltroTipo;
        private System.Windows.Forms.ComboBox CnombreProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_prod;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_tipoproducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion_prod;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_unitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn cant_producto;
        private System.Windows.Forms.DataGridViewImageColumn foto_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewButtonColumn Editar_produ;
        private System.Windows.Forms.DataGridViewTextBoxColumn Eliminar_produ;
    }
}